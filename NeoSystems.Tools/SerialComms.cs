/*
                    GNU LESSER GENERAL PUBLIC LICENSE
                       Version 3, 29 June 2007

 Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.


  This version of the GNU Lesser General Public License incorporates
the terms and conditions of version 3 of the GNU General Public
License, supplemented by the additional permissions listed below.

  0. Additional Definitions.

  As used herein, "this License" refers to version 3 of the GNU Lesser
General Public License, and the "GNU GPL" refers to version 3 of the GNU
General Public License.

  "The Library" refers to a covered work governed by this License,
other than an Application or a Combined Work as defined below.

  An "Application" is any work that makes use of an interface provided
by the Library, but which is not otherwise based on the Library.
Defining a subclass of a class defined by the Library is deemed a mode
of using an interface provided by the Library.

  A "Combined Work" is a work produced by combining or linking an
Application with the Library.  The particular version of the Library
with which the Combined Work was made is also called the "Linked
Version".

  The "Minimal Corresponding Source" for a Combined Work means the
Corresponding Source for the Combined Work, excluding any source code
for portions of the Combined Work that, considered in isolation, are
based on the Application, and not on the Linked Version.

  The "Corresponding Application Code" for a Combined Work means the
object code and/or source code for the Application, including any data
and utility programs needed for reproducing the Combined Work from the
Application, but excluding the System Libraries of the Combined Work.

  1. Exception to Section 3 of the GNU GPL.

  You may convey a covered work under sections 3 and 4 of this License
without being bound by section 3 of the GNU GPL.

  2. Conveying Modified Versions.

  If you modify a copy of the Library, and, in your modifications, a
facility refers to a function or data to be supplied by an Application
that uses the facility (other than as an argument passed when the
facility is invoked), then you may convey a copy of the modified
version:

   a) under this License, provided that you make a good faith effort to
   ensure that, in the event an Application does not supply the
   function or data, the facility still operates, and performs
   whatever part of its purpose remains meaningful, or

   b) under the GNU GPL, with none of the additional permissions of
   this License applicable to that copy.

  3. Object Code Incorporating Material from Library Header Files.

  The object code form of an Application may incorporate material from
a header file that is part of the Library.  You may convey such object
code under terms of your choice, provided that, if the incorporated
material is not limited to numerical parameters, data structure
layouts and accessors, or small macros, inline functions and templates
(ten or fewer lines in length), you do both of the following:

   a) Give prominent notice with each copy of the object code that the
   Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the object code with a copy of the GNU GPL and this license
   document.

  4. Combined Works.

  You may convey a Combined Work under terms of your choice that,
taken together, effectively do not restrict modification of the
portions of the Library contained in the Combined Work and reverse
engineering for debugging such modifications, if you also do each of
the following:

   a) Give prominent notice with each copy of the Combined Work that
   the Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the Combined Work with a copy of the GNU GPL and this license
   document.

   c) For a Combined Work that displays copyright notices during
   execution, include the copyright notice for the Library among
   these notices, as well as a reference directing the user to the
   copies of the GNU GPL and this license document.

   d) Do one of the following:

       0) Convey the Minimal Corresponding Source under the terms of this
       License, and the Corresponding Application Code in a form
       suitable for, and under terms that permit, the user to
       recombine or relink the Application with a modified version of
       the Linked Version to produce a modified Combined Work, in the
       manner specified by section 6 of the GNU GPL for conveying
       Corresponding Source.

       1) Use a suitable shared library mechanism for linking with the
       Library.  A suitable mechanism is one that (a) uses at run time
       a copy of the Library already present on the user's computer
       system, and (b) will operate properly with a modified version
       of the Library that is interface-compatible with the Linked
       Version.

   e) Provide Installation Information, but only if you would otherwise
   be required to provide such information under section 6 of the
   GNU GPL, and only to the extent that such information is
   necessary to install and execute a modified version of the
   Combined Work produced by recombining or relinking the
   Application with a modified version of the Linked Version. (If
   you use option 4d0, the Installation Information must accompany
   the Minimal Corresponding Source and Corresponding Application
   Code. If you use option 4d1, you must provide the Installation
   Information in the manner specified by section 6 of the GNU GPL
   for conveying Corresponding Source.)

  5. Combined Libraries.

  You may place library facilities that are a work based on the
Library side by side in a single library together with other library
facilities that are not Applications and are not covered by this
License, and convey such a combined library under terms of your
choice, if you do both of the following:

   a) Accompany the combined library with a copy of the same work based
   on the Library, uncombined with any other library facilities,
   conveyed under the terms of this License.

   b) Give prominent notice with the combined library that part of it
   is a work based on the Library, and explaining where to find the
   accompanying uncombined form of the same work.

  6. Revised Versions of the GNU Lesser General Public License.

  The Free Software Foundation may publish revised and/or new versions
of the GNU Lesser General Public License from time to time. Such new
versions will be similar in spirit to the present version, but may
differ in detail to address new problems or concerns.

  Each version is given a distinguishing version number. If the
Library as you received it specifies that a certain numbered version
of the GNU Lesser General Public License "or any later version"
applies to it, you have the option of following the terms and
conditions either of that published version or of any later version
published by the Free Software Foundation. If the Library as you
received it does not specify a version number of the GNU Lesser
General Public License, you may choose any version of the GNU Lesser
General Public License ever published by the Free Software Foundation.

  If the Library as you received it specifies that a proxy can decide
whether future versions of the GNU Lesser General Public License shall
apply, that proxy's public statement of acceptance of any version is
permanent authorization for you to choose that version for the
Library.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace NeoSystems.Tools
{
    // ********************************************************************
    /// <summary>
    /// General Serialcomms functions
    /// </summary>
    public class SerialComms
    {
        /// <summary>
        /// Baudrate flags
        /// </summary>
        [Flags]
        public enum BaudFlags : uint
        {
            /// <summary>75 bps</summary>
            BAUD_075 = 0x00000001, // 75 bps

            /// <summary>110 bps</summary>
            BAUD_110 = 0x00000002, // 110 bps

            /// <summary>134.5 bps</summary>
            BAUD_134_5 = 0x00000004, // 134.5 bps

            /// <summary>150 bps</summary>
            BAUD_150 = 0x00000008, // 150 bps

            /// <summary>300 bps</summary>
            BAUD_300 = 0x00000010, // 300 bps

            /// <summary>600 bps</summary>
            BAUD_600 = 0x00000020, // 600 bps

            /// <summary>1200 bps</summary>
            BAUD_1200 = 0x00000040, // 1200 bps

            /// <summary>1800 bps</summary>
            BAUD_1800 = 0x00000080, // 1800 bps

            /// <summary>2400 bps</summary>
            BAUD_2400 = 0x00000100, // 2400 bps

            /// <summary>4800 bps</summary>
            BAUD_4800 = 0x00000200, // 4800 bps

            /// <summary>7200 bps</summary>
            BAUD_7200 = 0x00000400, // 7200 bps

            /// <summary>9600 bps</summary>
            BAUD_9600 = 0x00000800, // 9600 bps

            /// <summary>14400 bps</summary>
            BAUD_14400 = 0x00001000, // 14400 bps

            /// <summary>19200 bps</summary>
            BAUD_19200 = 0x00002000, // 19200 bps

            /// <summary>38400 bps</summary>
            BAUD_38400 = 0x00004000, // 38400 bps

            /// <summary>56000 bps</summary>
            BAUD_56K = 0x00008000, // 56K bps

            /// <summary>57600 bps</summary>
            BAUD_57600 = 0x00040000, // 57600 bps

            /// <summary>115200 bps</summary>
            BAUD_115200 = 0x00020000, // 115200 bps

            /// <summary>128 kbps</summary>
            BAUD_128K = 0x00010000, // 128K bps

            /// <summary>User bps</summary>
            BAUD_USER = 0x10000000  // Programmable baud rate.
        }

        // ********************************************************************
        /// <summary>
        /// GetMaxBaudrate determines the maximum baudrate for portName
        /// </summary>
        /// <param name="portName">Name of com port</param>
        /// <returns>Maximum Buadrate or -1 if an error occurred</returns>
        public static int GetMaxBaudrate(string portName)
        {
            Int32 bv;

            try
            {
                SerialPort _port = new SerialPort(portName);
                _port.Open();
                object p = _port.BaseStream.GetType().GetField("commProp",
                    BindingFlags.Instance |
                    BindingFlags.NonPublic).GetValue(_port.BaseStream);
                bv = (Int32)p.GetType().GetField("dwSettableBaud",
                    BindingFlags.Instance |
                    BindingFlags.NonPublic | BindingFlags.Public).GetValue(p);
                _port.Close();
            }
            catch
            {
                bv = -1;
            }
            return bv;
        }

        // ********************************************************************
        /// <summary>
        /// Convert a baudrate mask to a string to display
        /// </summary>
        /// <param name="x">x = baudrate capability mask</param>
        /// <returns>string containing available baudrates</returns>
        public static string BuadrateMaskToString(int x)
        {
            BaudFlags t = (BaudFlags)x;
            StringBuilder s = new StringBuilder(2048);

            if ((t & BaudFlags.BAUD_075) != 0) s.Append("75 bps, ");
            if ((t & BaudFlags.BAUD_110) != 0) s.Append("110 bps, ");
            if ((t & BaudFlags.BAUD_134_5) != 0) s.Append("134.5 bps, ");
            if ((t & BaudFlags.BAUD_150) != 0) s.Append("150 bps, ");
            if ((t & BaudFlags.BAUD_300) != 0) s.Append("300 bps, ");
            if ((t & BaudFlags.BAUD_600) != 0) s.Append("600 bps, ");
            if ((t & BaudFlags.BAUD_1200) != 0) s.Append("1200 bps, ");
            if ((t & BaudFlags.BAUD_1800) != 0) s.Append("1800 bps, ");
            if ((t & BaudFlags.BAUD_2400) != 0) s.Append("2400 bps, ");
            if ((t & BaudFlags.BAUD_4800) != 0) s.Append("4800 bps, ");
            if ((t & BaudFlags.BAUD_7200) != 0) s.Append("7200 bps, ");
            if ((t & BaudFlags.BAUD_9600) != 0) s.Append("9600 bps, ");
            if ((t & BaudFlags.BAUD_14400) != 0) s.Append("14400 bps, ");
            if ((t & BaudFlags.BAUD_19200) != 0) s.Append("19200 bps, ");
            if ((t & BaudFlags.BAUD_38400) != 0) s.Append("38400 bps, ");
            if ((t & BaudFlags.BAUD_56K) != 0) s.Append("56 kbps, ");
            if ((t & BaudFlags.BAUD_57600) != 0) s.Append("57600 bps, ");
            if ((t & BaudFlags.BAUD_115200) != 0) s.Append("115200 bps, ");
            if ((t & BaudFlags.BAUD_128K) != 0) s.Append("128 kbps, ");
            if ((t & BaudFlags.BAUD_USER) != 0) s.Append("User bps, ");

            return s.ToString();
        }
    }

}
