using System;
using System.Reflection;

namespace Extensor
{
    /// <summary>
    /// Returns true if the object reference is null
    /// </summary>
    public static class ObjectExtensions
    {
        public static bool IsNull(this object o) => o == null;
    }
}
