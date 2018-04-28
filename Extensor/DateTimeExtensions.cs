using System;
namespace Extensor
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns the amount of days left between the enddate and current date
        /// </summary>
        /// <param name="current">Date.</param>
        /// <param name="endDate">End date.</param>
        public static int DaysTo(this DateTime current, DateTime endDate) => endDate.Subtract(current).Days;

        /// <summary>
        /// Returns true if the date is greater than the current DateTime.Now
        /// </summary>
        /// <param name="dateTime">Date time.</param>
        public static bool InTheFuture(this DateTime dateTime) => dateTime > DateTime.Now;

        /// <summary>
        /// Returns true if the date is between from and to.
        /// </summary>
        /// <param name="date">Date.</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public static bool IsBetween(this DateTime date, DateTime from, DateTime to) => date >= from && date <= to;

        /// <summary>
        /// Returns true if the date is between from and to.
        /// </summary>
        /// <param name="date">Date.</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public static bool IsNotBetween(this DateTime date, DateTime from, DateTime to) => date < from || date > to;

        /// <summary>
        /// Returns true if the given date is Sunday
        /// </summary>
        /// <param name="current">Current.</param>
        public static bool IsSunday(this DateTime current) => current.DayOfWeek == DayOfWeek.Sunday;

        /// <summary>
        /// Returns true if the given date is Monday
        /// </summary>
        /// <param name="current">Current.</param>
        public static bool IsMonday(this DateTime current) => current.DayOfWeek == DayOfWeek.Monday;

        /// <summary>
        /// Returns true if the given date is Tuesday
        /// </summary>
        /// <param name="current">Current.</param>

        public static bool IsTuesday(this DateTime current) => current.DayOfWeek == DayOfWeek.Tuesday;

        /// <summary>
        /// Returns true if the given date is Wednesday
        /// </summary>
        /// <param name="current">Current.</param>
        public static bool IsWednesday(this DateTime current) => current.DayOfWeek == DayOfWeek.Wednesday;

        /// <summary>
        /// Returns true if the given date is Thursday
        /// </summary>
        /// <param name="current">Current.</param>
        public static bool IsThursday(this DateTime current) => current.DayOfWeek == DayOfWeek.Thursday;

        /// <summary>
        /// Returns true if the given date is Friday
        /// </summary>
        /// <param name="current">Current.</param>
        public static bool IsFriday(this DateTime current) => current.DayOfWeek == DayOfWeek.Friday;

        /// <summary>
        /// Returns true if the given date is Saturay
        /// </summary>
        /// <param name="current">Current.</param>
        public static bool IsSaturday(this DateTime current) => current.DayOfWeek == DayOfWeek.Saturday;

    }
}
