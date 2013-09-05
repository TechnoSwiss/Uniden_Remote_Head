using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;

namespace Uniden_Remote_Head
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledException);
            string logfile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\logfile.txt";

            try
            {
                Application.Run(new UnidenRemoteHead());
            }
            catch (Exception exception)
            {
                StreamWriter writer = new StreamWriter(logfile, true);
                writer.WriteLine(DateTime.Now.ToString() + " Main Application Bombed - " + exception.ToString());
                writer.Close();
            }
        }

        static void UnhandledException(object sender, UnhandledExceptionEventArgs exception)
        {
            string logfile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\logfile.txt";

            StreamWriter writer = new StreamWriter(logfile, true);
            writer.WriteLine(DateTime.Now.ToString() + " Main Application Bombed - " + exception.ToString());
            writer.Close();
        }
    }
}