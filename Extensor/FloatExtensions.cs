using System.Linq;

namespace Extensor
{
    public static class FloatExtensions
    {
        /// <summary>
        /// Returns true if the value specified is between the given min and max values.
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static bool IsBetween(this float v, float min, float max) => v >= min && v <= max;

        /// <summary>
        /// Returns true if the value specified is not between the given min and max values.
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static bool IsNotBetween(this float v, float min, float max) => v < min || v > max;

        /// <summary>
        /// Returns true if the value in question is within the suplied values. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool In(this float v, params float[] values) => values.Contains(v);

        /// <summary>
        /// Returns true if the value in question is not within the suplied values. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>       
        public static bool NotIn(this float v, params float[] values) => !values.Contains(v);
    }
}
