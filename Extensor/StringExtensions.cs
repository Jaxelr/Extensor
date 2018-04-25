using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extensor
{
    public static class StringExtensions
    {
        public static bool HasText(this string v) => !string.IsNullOrWhiteSpace(v);

        public static bool In(this string v, params string[] values) => values.Contains(v);

        public static bool In(this string v, IEnumerable<string> values) => values.Contains(v);

        public static bool InIgnoringCasing(this string v, params string[] values)
        {
            return values.Select(vs => vs.ToLower()).Contains(v.ToLower());
        }

        public static bool InIgnoringCasing(this string v, IEnumerable<string> values)
        {
            return values.Select(vs => vs.ToLower()).Contains(v.ToLower());
        }

        public static bool IsADate(this string v)
        {
            DateTime dateTime;
            return DateTime.TryParse(v, out dateTime);
        }

        public static bool IsEmpty(this string v) => string.IsNullOrWhiteSpace(v);

        public static bool NotIn(this string v, params string[] values) => !values.Contains(v);

        public static bool NotIn(this string v, IEnumerable<string> values) => !values.Contains(v);

        public static bool NotInIgnoringCasing(this string v, params string[] values)
        {
            return !values.Select(vs => vs.ToLower()).Contains(v.ToLower());
        }

        public static bool NotInIgnoringCasing(this string v, IEnumerable<string> values)
        {
            return !values.Select(vs => vs.ToLower()).Contains(v.ToLower());
        }

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

        public static IEnumerable<string> SplitByEnvironmentNewLine(this string v)
        {
            return v.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        public static byte[] ToByteArray(this string text, Encoding encoding){
            return encoding.GetBytes(text);
        }

        public static string ValueBetween(this string v, string foo, string bar)
        {
            var start = v.IndexOf(foo, StringComparison.OrdinalIgnoreCase) + foo.Length;
            var end = v.LastIndexOf(bar, StringComparison.OrdinalIgnoreCase);

            return v.Substring(start, end - start).Trim();
        }
    }
}
