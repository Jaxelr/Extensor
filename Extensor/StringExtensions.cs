using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extensor
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns true if the string is not null, whitespace or empty.
        /// </summary>
        /// <param name="v">V.</param>
        public static bool HasText(this string v) => !string.IsNullOrWhiteSpace(v);

        /// <summary>
        /// Returns true if the value is found within the values specified. This method is case sensitive. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool In(this string v, params string[] values) => values.Contains(v);

        /// <summary>
        /// Returns true if the value is found within the values specified. This method is case sensitive. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool In(this string v, IEnumerable<string> values) => values.Contains(v);

        /// <summary>
        /// Returns true if the value is found within the values specified. This method is not case sensitive. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool InIgnoringCasing(this string v, params string[] values)
        {
            return values.Select(vs => vs.ToLower()).Contains(v.ToLower());
        }

        /// <summary>
        /// Returns true if the value is found within the values specified. This method is not case sensitive. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool InIgnoringCasing(this string v, IEnumerable<string> values)
        {
            return values.Select(vs => vs.ToLower()).Contains(v.ToLower());
        }

        /// <summary>
        /// Returns true if the value specified parses to a DateTime object. 
        /// </summary>
        /// <param name="v">V.</param>
        public static bool IsADate(this string v)
        {
            DateTime dateTime;
            return DateTime.TryParse(v, out dateTime);
        }

        /// <summary>
        /// Returns true if the string is null, whitespace or empty.
        /// </summary>
        /// <param name="v">V.</param>
        public static bool IsEmpty(this string v) => string.IsNullOrWhiteSpace(v);

        /// <summary>
        /// Returns true if the value is not found within the values specified. This method is case sensitive. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool NotIn(this string v, params string[] values) => !values.Contains(v);

        /// <summary>
        /// Returns true if the value is not found within the values specified. This method is case sensitive. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool NotIn(this string v, IEnumerable<string> values) => !values.Contains(v);

        /// <summary>
        /// Returns true if the value is not found within the values specified. This method is not case sensitive. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool NotInIgnoringCasing(this string v, params string[] values)
        {
            return !values.Select(vs => vs.ToLower()).Contains(v.ToLower());
        }

        /// <summary>
        /// Returns true if the value is not found within the values specified. This method is not case sensitive. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool NotInIgnoringCasing(this string v, IEnumerable<string> values)
        {
            return !values.Select(vs => vs.ToLower()).Contains(v.ToLower());
        }

        /// <summary>
        /// Removes everything from the specified delimeter and returns the new value. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="delimeter">Delimeter.</param>
        public static string RemoveEverythingBefore(this string v, char delimeter)
        {

            var tmp = v.ToCharArray();
            Array.Reverse(tmp);

            int startingIndex = -1;
            startingIndex = new string(tmp).LastIndexOf(delimeter);

            if (startingIndex == -1)
                return null;

            tmp = new string(tmp).Remove(startingIndex + 1).ToCharArray();
            Array.Reverse(tmp);

            return new string(tmp);
        }

        /// <summary>
        /// Splits the given value by newline and returns. 
        /// </summary>
        /// <param name="v">V.</param>
        public static IEnumerable<string> SplitByEnvironmentNewLine(this string v)
        {
            return v.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Returns a byte array for the given string value using the encoding provided. 
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="encoding">Encoding.</param>
        public static byte[] ToByteArray(this string text, Encoding encoding){
            return encoding.GetBytes(text);
        }

        /// <summary>
        /// Returns the string value between foo and bar
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="foo">Foo.</param>
        /// <param name="bar">Bar.</param>
        public static string ValueBetween(this string v, string foo, string bar)
        {
            var start = v.IndexOf(foo, StringComparison.OrdinalIgnoreCase) + foo.Length;
            var end = v.LastIndexOf(bar, StringComparison.OrdinalIgnoreCase);

            return v.Substring(start, end - start).Trim();
        }
    }
}
