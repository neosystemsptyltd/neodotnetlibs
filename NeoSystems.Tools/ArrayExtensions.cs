﻿/*
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
using System.Text;
using System.Threading.Tasks;

namespace NeoSystems.Tools
{
    /// <summary>
    /// Array extensions
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// remove an item at specific index from array
        /// </summary>
        /// <typeparam name="T">array class type</typeparam>
        /// <param name="source">array to remove item from</param>
        /// <param name="index">index to remove at</param>
        /// <returns>new array with item removed</returns>
        public static T[] RemoveAt<T>(this T[] source, int index)
        {
            T[] dest = new T[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, dest, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

            return dest;
        }

        /// <summary>
        /// Remove all specific constants from an array
        /// </summary>
        /// <param name="source">array to remove from</param>
        /// <param name="val">value to remove</param>
        /// <returns>new array with removed items</returns>
        public static T[] RemoveAll<T>(this T[] source, T val)
        {
            T[] dest = new T[source.Length];

            int i = 0;
            foreach (T e in source)
            {
                if (!EqualityComparer<T>.Default.Equals(e, val))
                {
                    dest[i] = e;
                    i++;
                }
            }
            Array.Resize(ref dest, i);

            return dest;
        }

        /// <summary>
        /// Append a item at the end of the array
        /// </summary>
        /// <param name="source">array class instance</param>
        /// <param name="val">value to append at the end</param>
        /// <returns>array</returns>
        public static T[] Append<T>(this T[] source, T val)
        {
            int index = source.Length;
            Array.Resize<T>(ref source, index + 1);
            source[index] = val;

            return source;
        }

        /// <summary>
        /// Insert item at a specific point in an array.
        /// Please note that a lot of copying goes on with this method.
        /// Thus it is not very efficient to insert into an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">array ref</param>
        /// <param name="Val">Value to insert</param>
        /// <param name="idx">index where the value is to be inserted</param>
        /// <returns>a copy of a new array</returns>
        public static T[] InsertAt<T>(this T[] source, T Val, int idx)
        {
            int i;

            Array.Resize<T>(ref source, source.Length + 1);

            for (i = idx + 1; i < source.Count(); i++)
            {
                source[i] = source[i - 1];
            }

            source[idx] = Val;

            return source;

        }

        /// <summary>
        /// extension method to resize 2 multi dimensional array
        /// </summary>
        /// <param name="arr">array to resize</param>
        /// <param name="newSizes">array of new sizes for the array to be resized</param>
        /// <returns>New resized array</returns>
        public static Array ResizeArray(this Array arr, int[] newSizes)
        {
            if (newSizes.Length != arr.Rank)
            {
                throw new ArgumentException("arr must have the same number of dimensions as there are elements in newSizes", "newSizes");
            }

            var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
            var sizesToCopy = new int[newSizes.Length];
            for (var i = 0; i < sizesToCopy.Length; i++)
            {
                sizesToCopy[i] = System.Math.Min(newSizes[i], arr.GetLength(i));
            }

            var currentPositions = new int[sizesToCopy.Length];
            CopyArray(arr, temp, sizesToCopy, currentPositions, 0);

            return temp;
        }

        private static void CopyArray(Array arr, Array temp, int[] sizesToCopy, int[] currentPositions, int dimmension)
        {
            if (arr.Rank - 1 == dimmension)
            {
                //Copy this Array
                for (var i = 0; i < sizesToCopy[dimmension]; i++)
                {
                    currentPositions[dimmension] = i;
                    temp.SetValue(arr.GetValue(currentPositions), currentPositions);
                }
            }
            else
            {
                //Recursion one dimmension higher
                for (var i = 0; i < sizesToCopy[dimmension]; i++)
                {
                    currentPositions[dimmension] = i;
                    CopyArray(arr, temp, sizesToCopy, currentPositions, dimmension + 1);
                }
            }
        }
    }

}
