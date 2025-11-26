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
            return Array.Exists(weekendDays, d => d == value.DayOfWeek);
        }

        #endregion

    }
}
