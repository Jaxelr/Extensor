using System.Collections.Generic;
using System.Linq;

namespace Extensor
{
    public static class ShortExtensions
    {
        public static bool In(this short v, params short[] values) => values.Contains(v);

        public static bool In(this short v, IEnumerable<short> values) => values.Contains(v);
    }
}
