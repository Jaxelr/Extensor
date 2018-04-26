using System.Linq;

namespace Extensor
{
    public static class IntExtensions
    {
        /// <summary>
        /// Returns true if the value specified is between the given min and max values.
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static bool IsBetween(this int v, int min, int max) => v >= min && v <= max;

        /// <summary>
        /// Returns true if the value specified is not between the given min and max values.
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static bool IsNotBetween(this int v, int min, int max) => v < min || v > max;

        /// <summary>
        /// Returns true if the value in question is within the suplied values. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool In(this int v, params int[] values) => values.Contains(v);

        /// <summary>
        /// Returns true if the value in question is not within the suplied values. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>       
        public static bool NotIn(this int v, params int[] values) => !values.Contains(v);
    }
}
