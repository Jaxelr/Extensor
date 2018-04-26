namespace Extensor
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Returns 1 if true else 0
        /// </summary>
        /// <param name="condition">If set to <c>true</c> condition.</param>
        public static int ToNumericValue(this bool condition) => condition ? 1 : 0;

        /// <summary>
        /// Returns YES if true else returns NO
        /// </summary>
        /// <returns>The yes or no.</returns>
        /// <param name="condition">If set to <c>true</c> condition.</param>
        public static string ToYesOrNo(this bool condition) => condition ? "YES" : "NO";
    }
}
