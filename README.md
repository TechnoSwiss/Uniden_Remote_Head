Uniden_Remote_Head
==================

.Net CF 2.0 Remote Head application for Uniden BCT15X Scanner

This Application was built to run on a Dell Axim x50v, running Windows Mobile 6.0

It requires a serial port adaptor to connect to the Uniden Scanner.

There is a known serial port bug in the .Net framework where an unhandled exception error in the serial code will
cause the application to abort. There are some work arounds for this in the regular framework, but was unable to
find a work around for the Compact Framework. The consequence of this is, sometime the application will just disappear.

There is a settings.xml file that contains the comm port settings, and also saves the values for volume, squelch, and mute.
These values are written back the file as they are changed.

The scanner is polled, and if it fails to respond it will be marked as disconnected. When the scanner is found after
having been disconnected, the values for Volume and Squelch will be re-sent to the scanner. Otherwise the scanner would
default to the levels determined by the knobs at power up.
