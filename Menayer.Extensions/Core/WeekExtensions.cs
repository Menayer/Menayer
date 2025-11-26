using System.Globalization;
using Menayer.Extensions.Core.Helpers;
namespace Menayer.Extensions.Core

{
    /// <summary>
    /// Focus: Weekdays, weekends, week navigation, and comparisons.
    /// </summary>
    public static class WeekExtensions
    {
        #region Weekday and Weekend Checks
        public static bool IsWeekEnd(this DateTime value, CultureInfo? currentCulture = null)
        {
            var weekendDays = WeekendHelper.GetWeekendDays(currentCulture ?? CultureInfo.CurrentCulture);
            return weekendDays.Contains(value.DayOfWeek);
        }

        public static bool IsWeekEnd(this DateTime value, DayOfWeek startWeekendDay, int numberOfDays = 2)
        {
            var weekendDays = WeekendHelper.GetWeekendDays(startWeekendDay, numberOfDays);
            return weekendDays.Contains(value.DayOfWeek);
        }

        public static bool IsWeekEnd(this string value, CultureInfo? currentCulture = null)
        {
            if (!Enum.TryParse(value, true, out DayOfWeek day)) return false;
            var weekendDays = WeekendHelper.GetWeekendDays(currentCulture ?? CultureInfo.CurrentCulture);
            return weekendDays.Contains(day);
        }

        public static bool IsWeekEnd(this string value, DayOfWeek startWeekendDay, int numberOfDays = 2)
        {
            if (!Enum.TryParse(value, true, out DayOfWeek day)) return false;
            var weekendDays = WeekendHelper.GetWeekendDays(startWeekendDay, numberOfDays);
            return weekendDays.Contains(day);
        }

        public static bool IsWeekEnd(this DayOfWeek value, CultureInfo? currentCulture = null)
        {
            var weekendDays = WeekendHelper.GetWeekendDays(currentCulture ?? CultureInfo.CurrentCulture);
            return weekendDays.Contains(value);
        }

        public static bool IsWeekEnd(this DayOfWeek value, DayOfWeek startWeekendDay, int numberOfDays = 2)
        {
            var weekendDays = WeekendHelper.GetWeekendDays(startWeekendDay, numberOfDays);
            return weekendDays.Contains(value);
        }

        public static bool IsWeekEnd(this DateOnly value, CultureInfo? currentCulture = null)
        {
            var weekendDays = WeekendHelper.GetWeekendDays(currentCulture ?? CultureInfo.CurrentCulture);
            return weekendDays.Contains(value.DayOfWeek);
        }

        public static bool IsWeekEnd(this DateOnly value, DayOfWeek startWeekendDay, int numberOfDays = 2)
        {
            var weekendDays = WeekendHelper.GetWeekendDays(startWeekendDay, numberOfDays);
            return weekendDays.Contains(value.DayOfWeek);
        }

        #endregion

    }
}
