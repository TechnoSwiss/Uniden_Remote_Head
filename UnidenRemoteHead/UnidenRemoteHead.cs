//I had taken a look at the following software before creating my version
//Ultimately I didn't end up using their code, but I may have subconsciously
//modeled some functions after theirs
//WM15 Control Software for the Uniden BCT15 radio scanner
//(C) Stefano "Sinager" Sinagra IZ0MJE www.tarapippo.net
//free for non commercial use

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Xml.Serialization;

namespace Uniden_Remote_Head
{
    public partial class UnidenRemoteHead : Form
    {
        public class Settings
        {
            public Communication xmlCommunication = new Communication();
            public Scanner xmlScanner = new Scanner();
        }

        public class Communication
        {
            public string comPort = "COM1";
            public int baudRate = 115200;
        }
        public class Scanner
        {
            public int volume = 25;
            public int squelch = 14;
            public Boolean mute = false;
        }

        private SerialPort portScanner;
        private Settings scannerSettings;

        private string filename = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\settings.xml";
        private string logfile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\logfile.txt";
        private int failedRead = 1;
        private Boolean scannerStateKnown = false;

        private Boolean UpdateSettings = false;

        public UnidenRemoteHead()
        {
            InitializeComponent();

            if (File.Exists(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                FileStream fs = new FileStream(filename, FileMode.Open);
                try
                {
                    scannerSettings = (Settings)serializer.Deserialize(fs);
                    fs.Close();
                }
                catch (Exception exception)
                {
                    WriteLog(logfile, "Failed to Read Settings - " + exception.ToString());
                    // if we failed, most likely cause was a messed up XML file
                    // create default class, then write output to XML
                    fs.Close(); //File is still open, so close it or UpdateSettingsXML won't be able to write to it
                    scannerSettings = new Settings();
                    UpdateSettingsXML();
                }
            }
            else
            {
                // Ideally we could use the XML default flags to set the values
                // but that doesn't seem to work in the CF, so we're instantiating
                // the default class before creatig a new XML file
                scannerSettings = new Settings();
                UpdateSettingsXML();
            }

            KeyPreview = true;

            //... instantiate SerialPort
            portScanner = new SerialPort(scannerSettings.xmlCommunication.comPort);

            //... Configure Port
            portScanner.BaudRate = scannerSettings.xmlCommunication.baudRate;
            portScanner.DataBits = 8;
            portScanner.Parity = Parity.None;
            portScanner.StopBits = StopBits.One;
            portScanner.DtrEnable = false;
            portScanner.RtsEnable = false;

            portScanner.Open();
            

            timerReadScanner.Enabled = true;
            timerUpdateSettingsXML.Enabled = true;
        }

        private Boolean UnidenWrite(string Button)
        {
            try
            {
               portScanner.WriteLine(Button + "\r");
            }
            catch (Exception exception)
            {
                WriteLog(logfile, "Failed to Write Serial Port - " + exception.ToString());
                return true;
            }
            return false;
        }

        private byte[] UnidenRead()
        {
            int readBytes = 0;

            try
            {
                readBytes = portScanner.BytesToRead;
            }
            catch (Exception exception)
            {
                WriteLog(logfile, "Failed to Read Serial Port - " + exception.ToString());
                // don't know what to do here if we fail
                failedRead++;
            }

            byte[] byteRead = new byte[readBytes];
            if (readBytes == 0)
                failedRead++;

            try
            {
                portScanner.Read(byteRead, 0, readBytes);
                //Would like to set failedRead to zero here
                //however we don't want to set it to zero
                //until the read returns scanner data vs
                //returning say, startup info
                //if (readBytes > 0)
                //    failedRead = 0;
            }
            catch (Exception exception)
            {
                WriteLog(logfile, "Failed to Read Serial Port - " + exception.ToString());
                // don't know what to do here if we fail
                failedRead++;
            }

            return byteRead;
        }

        private void UpdateSettingsXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, scannerSettings);
            writer.Close();
            return;
        }

        private void UnidenRemoteHead_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Rocker Up
                // Up
                if (scannerSettings.xmlScanner.volume < 30)
                {
                    scannerSettings.xmlScanner.volume += 1;
                }
                UnidenWrite("VOL," + scannerSettings.xmlScanner.volume.ToString());
                UpdateSettings = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Rocker Down
                // Down
                if (scannerSettings.xmlScanner.volume > 0)
                {
                    scannerSettings.xmlScanner.volume -= 1;
                }
                UnidenWrite("VOL," + scannerSettings.xmlScanner.volume.ToString());
                UpdateSettings = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
                if (scannerSettings.xmlScanner.squelch < 19)
                {
                    scannerSettings.xmlScanner.squelch += 1;
                }
                UnidenWrite("SQL," + scannerSettings.xmlScanner.squelch.ToString());
                UpdateSettings = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
                if (scannerSettings.xmlScanner.squelch > 0)
                {
                    scannerSettings.xmlScanner.squelch -= 1;
                }
                UnidenWrite("SQL," + scannerSettings.xmlScanner.squelch.ToString());
                UpdateSettings = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
                if (scannerSettings.xmlScanner.mute)
                {
                    UnidenWrite("VOL," + scannerSettings.xmlScanner.volume.ToString());
                    scannerSettings.xmlScanner.mute = false;
                }
                else
                {
                    UnidenWrite("VOL,0");
                    scannerSettings.xmlScanner.mute = true;
                }
                UpdateSettings = true;
            }
            e.Handled = true;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,<,P");
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,>,P");
        }

        private void timerReadScanner_Tick(object sender, EventArgs e)
        {
            // As part of the reading the scanner, we want to setup the scanner state (vol/squelch)
            // So if we don't know the scanner state, and failedRead is 0 (so we know we have communication
            // with the scanner, then we'll send the vol/squelch values)
            if (scannerStateKnown != true && failedRead == 0)
            {
                UnidenWrite("SQL," + scannerSettings.xmlScanner.squelch.ToString());

                if (scannerSettings.xmlScanner.mute)
                    UnidenWrite("VOL,0");
                else
                    UnidenWrite("VOL," + scannerSettings.xmlScanner.volume.ToString());

                scannerStateKnown = true;
            }

            Encoding decodeByteArray = new UnicodeEncoding();
            
            UnidenWrite("STS");

            try
            {
                byte[] byteRead = UnidenRead();
                byteRead = Encoding.Convert(Encoding.Default, Encoding.Unicode, byteRead);
                string stringDecode = decodeByteArray.GetString(byteRead, 0, byteRead.GetLength(0));

                stringDecode = stringDecode.Replace(" ", "Λ");
                stringDecode = stringDecode.Replace("‚  ", "V");
                stringDecode = stringDecode.Replace("Ž", "HOLD");
                stringDecode = stringDecode.Replace("ø£╣║", "FMB");
                stringDecode = stringDecode.Replace("‹", "F");
                stringDecode = stringDecode.Replace("žœš", "NFM");
                stringDecode = stringDecode.Replace("›œš", "FM");
                stringDecode = stringDecode.Replace("˜™š", "AM");
                stringDecode = stringDecode.Replace("•–—", "L/O");
                stringDecode = stringDecode.Replace("µ¶", "©"); // Close Capture DND
                stringDecode = stringDecode.Replace("·¸", ""); // Close Capture DND Second Line
                stringDecode = stringDecode.Replace("‡ˆ", "©"); // Close Capture Primary
                stringDecode = stringDecode.Replace("‰Š", ""); // Close Capture Primary Second Line
                stringDecode = stringDecode.Replace("»¼", "M");
                stringDecode = stringDecode.Replace("¦", "▪      ");
                stringDecode = stringDecode.Replace("§", "▪▪     ");
                stringDecode = stringDecode.Replace("¨©", "▪▪▪    ");
                stringDecode = stringDecode.Replace("ª«", "▪▪▪▪   ");
                stringDecode = stringDecode.Replace("¬­", "▪▪▪▪▪  ");

                string[] stringRead = stringDecode.Split(',');

                if (failedRead > 5)
                {
                    switch (failedRead % 30)
                    {
                        case 0:
                            textDisplayLine1.Text = "";
                            textDisplayLine2.Text = "";
                            textDisplayLine3.Text = "Disconnected";
                            textDisplayLine4.Text = "";
                            textDisplayLine5.Text = "";
                            textDisplayLine6.Text = "";
                            break;
                        case 10:
                            textDisplayLine1.Text = "";
                            textDisplayLine2.Text = "";
                            textDisplayLine3.Text = "Disconnected.";
                            textDisplayLine4.Text = "";
                            textDisplayLine5.Text = "";
                            textDisplayLine6.Text = "";
                            break;
                        case 20:
                            textDisplayLine1.Text = "";
                            textDisplayLine2.Text = "";
                            textDisplayLine3.Text = "Disconnected..";
                            textDisplayLine4.Text = "";
                            textDisplayLine5.Text = "";
                            textDisplayLine6.Text = "";
                            break;
                    }
                    scannerStateKnown = false;
                }

                if (stringRead.Length == 19)
                {
                    // We've received scanner data, so zero out failedRead counted
                    failedRead = 0;

                    if (stringRead[3] == "****************")
                        stringRead[2] = "*" + stringRead[2];
                    textDisplayLine2.Text = stringRead[2];

                    if (stringRead[5] == "****************")
                        stringRead[4] = "*" + stringRead[4];
                    textDisplayLine3.Text = stringRead[4];

                    if (stringRead[7] == "****************")
                        stringRead[6] = "*" + stringRead[6];
                    textDisplayLine4.Text = stringRead[6];

                    if (stringRead[9] == "****************")
                        stringRead[8] = "*" + stringRead[8];
                    textDisplayLine5.Text = stringRead[8];
                }

                if (stringRead.Length == 23)
                {
                    // We've received scanner data, so zero out failedRead counted
                    failedRead = 0;
                    if (stringRead[2].Substring(0, 1) != "F")
                    {
                        if (stringRead[2].Substring(10, 1) != "▪")
                            stringRead[2] = stringRead[2].Insert(10, "     ");
                        if (stringRead[2].Substring(1, 4) != "HOLD")
                            stringRead[2] = stringRead[2].Insert(1, "    ");
                        //stringRead[2] = stringRead[2].Insert(1, " ");
                    }
                    stringRead[2] = stringRead[2].Insert(8, " ");
                    stringRead[2] = stringRead[2].Insert(5, " ");
                    stringRead[2] = stringRead[2].Insert(1, " ");

                    textDisplayLine1.Text = stringRead[2];
                    textDisplayLine2.Text = stringRead[4];
                    textDisplayLine3.Text = stringRead[6];
                    textDisplayLine4.Text = stringRead[8];
                    textDisplayLine5.Text = stringRead[10];
                    textDisplayLine6.Text = stringRead[12];
                }
            }
            catch (Exception exception)
            {
                WriteLog(logfile, "Failed to Parse String - " + exception.ToString());
            }
        }

        private void timerUpdateSettingsXML_Tick(object sender, EventArgs e)
        {
            if (UpdateSettings)
            {
                UpdateSettings = false;
                UpdateSettingsXML();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            UpdateSettingsXML();
            portScanner.Close();
            Close();
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,1,P");
        }

        private void buttonPOL_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,P,P");
        }

        private void buttonHP_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,W,P");
        }

        private void buttonGPS_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,G,P");
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,M,P");
        }

        private void buttonLO_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,L,P");
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,E,P");
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,2,P");
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,3,P");
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,4,P");
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,5,P");
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,6,P");
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,7,P");
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,8,P");
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,9,P");
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,0,P");
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,.,P");
        }

        private void buttonCloseCall_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,Q,P");
        }

        private void buttonBacklight_Click(object sender, EventArgs e)
        {
            Color setColor;

            if (textDisplayLine1.BackColor == Color.White) {
                setColor = Color.FromArgb(240, 0, 0);
            } else {
                setColor = Color.White;
            }

            //UnidenWrite("KEY,V,P");
            textDisplayLine1.BackColor = setColor;
            textDisplayLine2.BackColor = setColor;
            textDisplayLine3.BackColor = setColor;
            textDisplayLine4.BackColor = setColor;
            textDisplayLine5.BackColor = setColor;
            textDisplayLine6.BackColor = setColor;

            buttonExit.ForeColor = setColor;
            buttonPOL.ForeColor = setColor;
            buttonHP.ForeColor = setColor;
            buttonGPS.ForeColor = setColor;
            buttonMenu.ForeColor = setColor;
            buttonLO.ForeColor = setColor;

            buttonNum1.ForeColor = setColor;
            buttonNum2.ForeColor = setColor;
            buttonNum3.ForeColor = setColor;
            buttonNum4.ForeColor = setColor;
            buttonNum5.ForeColor = setColor;
            buttonNum6.ForeColor = setColor;
            buttonNum7.ForeColor = setColor;
            buttonNum8.ForeColor = setColor;
            buttonNum9.ForeColor = setColor;
            buttonNum0.ForeColor = setColor;

            buttonYes.ForeColor = setColor;
            buttonNo.ForeColor = setColor;
            buttonBacklight.ForeColor = setColor;
            buttonCloseCall.ForeColor = setColor;
            buttonScan.ForeColor = setColor;
            buttonHold.ForeColor = setColor;
            buttonDown.ForeColor = setColor;
            buttonUp.ForeColor = setColor;
            buttonFunction.ForeColor = setColor;
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,S,P");
        }

        private void buttonHold_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,H,P");
        }

        private void buttonFunction_Click(object sender, EventArgs e)
        {
            UnidenWrite("KEY,F,P");
        }

        public void WriteLog(string logFile, string logMessage)
        {
            StreamWriter writer = new StreamWriter(logFile, true);
            writer.WriteLine(DateTime.Now.ToString() + " " + logMessage);
            writer.Close();
        }
    }
}