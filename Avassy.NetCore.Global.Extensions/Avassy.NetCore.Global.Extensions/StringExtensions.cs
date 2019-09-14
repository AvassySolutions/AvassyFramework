﻿using System;
using System.Buffers.Text;
using System.Text;

namespace Avassy.NetCore.Global.Extensions
{
    /// <summary>
    /// This class holds string extension methods.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Removes the special characters and spaces in the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="charToReplaceSpace">The character to replacethe  space.</param>
        /// <returns>A cleaned string.</returns>
        public static string RemoveSpecialCharactersAndSpaces(this string str, char charToReplaceSpace = '-')
        {
            var sb = new StringBuilder();

            foreach (var c in str)
            {
                if ((c < '0' || c > '9') && (c < 'A' || c > 'Z') && (c < 'a' || c > 'z') && c != ' ')
                {
                    continue;
                }

                sb.Append(c == ' ' ? charToReplaceSpace : c);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Converts a simple string to a base64 encoded string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>A base64 encoded string.</returns>
        public static string ToBase64(this string str)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(str);

            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
