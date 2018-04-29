using System.Collections.Generic;
using System.Linq;

namespace Extensor
{
    /// <summary>
    /// Short extensions.
    /// </summary>
    public static class ShortExtensions
    {
        /// <summary>
        /// Returns true if value is within values. 
        /// </summary>
        /// <returns>The in.</returns>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool In(this short v, params short[] values) => values.Contains(v);

        /// <summary>
        /// Returns true if value is within values. 
        /// </summary>
        /// <returns>The in.</returns>
        /// <param name="v">V.</param>
        /// <param name="values">Values.</param>
        public static bool In(this short v, IEnumerable<short> values) => values.Contains(v);
    }
}
