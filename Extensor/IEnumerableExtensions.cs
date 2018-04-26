using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensor
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Calls an action on each item within the list. Returns the zero-based index of the last value in the list.
        /// </summary>
        /// <returns>The each.</returns>
        /// <param name="enumerable">Enumerable.</param>
        /// <param name="action">Action.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static int ForEach<T>(this IEnumerable<T> enumerable, Action<int, T> action)
        {
            var index = 0;

            foreach (var item in enumerable)
            {
                action(index++, item);
            }

            return index;
        }

        /// <summary>
        /// Returns true if the item count is greater than 0;
        /// </summary>
        /// <returns><c>true</c>, if records was hased, <c>false</c> otherwise.</returns>
        /// <param name="enumerable">Enumerable.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static bool HasRecords<T>(this IEnumerable<T> enumerable) => enumerable.Count() > 0;

        /// <summary>
        /// Returns the elements from the source that are missing in the given collection.
        /// </summary>
        /// <returns>The in.</returns>
        /// <param name="source">source.</param>
        /// <param name="collection">Collection.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static IEnumerable<T> MissingIn<T>(this IEnumerable<T> source, IEnumerable<T> collection)
        {
            var rv = new List<T>();
            foreach (var item in source)
            {
                if (!collection.Contains(item))
                    rv.Add(item);
            }
            return rv;
        }

        /// <summary>
        /// Returns a string contaning all items with a comma separated value (CSV) mask. 
        /// </summary>
        /// <returns>The comma separated values.</returns>
        /// <param name="enumerable">Enumerable.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static string ToCommaSeparatedValues<T>(this IEnumerable<T> enumerable)
        {
            string rv = string.Empty;
            for (var i = enumerable.GetEnumerator(); i.MoveNext();)
            {
                rv += i.Current + ",";
            }
            return rv.Remove(rv.LastIndexOf(",", StringComparison.Ordinal));
        }
    }
}
