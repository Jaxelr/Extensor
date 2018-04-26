using System.Linq;

namespace Extensor
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Returns true if the value specified is between the given min and max values.
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static bool IsBetween(this double v, double min, double max) => v >= min && v <= max;

        /// <summary>
        /// Returns true if the value specified is not between the given min and max values.
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static bool IsNotBetween(this double v, double min, double max) => v < min || v > max;
            
        /// <summary>
        /// Returns true if the value in question is within the suplied values. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool In(this double v, params double[] values) => values.Contains(v);

        /// <summary>
        /// Returns true if the value in question is not within the suplied values. 
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>       
        public static bool NotIn(this double v, params double[] values) => !values.Contains(v);
    }
}
