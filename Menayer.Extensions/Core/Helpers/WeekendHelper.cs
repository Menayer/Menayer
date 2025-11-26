
using System.Globalization;

namespace Menayer.Extensions.Core.Helpers
{
    public static class WeekendHelper
    {
        /// <summary>
        /// Dictionary mapping ISO country codes to weekend days.
        /// </summary>
        /// 
        public static readonly Dictionary<string, DayOfWeek[]> CountryWeekends = new(StringComparer.OrdinalIgnoreCase)
        {
            // Saturday & Sunday
            { "US", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "CA", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "GB", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "AU", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "NZ", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "IN", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "CN", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "JP", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "DE", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "FR", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "PH", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "MY", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "TR", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },
            { "RU", new [] { DayOfWeek.Saturday, DayOfWeek.Sunday } },

            // Friday & Saturday
            { "AE", new [] { DayOfWeek.Friday, DayOfWeek.Saturday } },
            { "SA", new [] { DayOfWeek.Friday, DayOfWeek.Saturday } },
            { "EG", new [] { DayOfWeek.Friday, DayOfWeek.Saturday } },
            { "IQ", new [] { DayOfWeek.Friday, DayOfWeek.Saturday } },
            { "PK", new [] { DayOfWeek.Friday, DayOfWeek.Saturday } },
            { "BD", new [] { DayOfWeek.Friday, DayOfWeek.Saturday } },

            // Thursday & Friday
            { "IR", new [] { DayOfWeek.Thursday, DayOfWeek.Friday } },

            // Saturday only
            { "NP", new [] { DayOfWeek.Saturday } }
        };
        public static DayOfWeek[] GetWeekendDays(CultureInfo? currentCulture)
        {
            if (string.IsNullOrWhiteSpace(currentCulture?.ToString()))
                return new[] { DayOfWeek.Saturday, DayOfWeek.Sunday };

            return CountryWeekends.TryGetValue(currentCulture.ToString().Substring(currentCulture.ToString().IndexOf("-")+1), out var days)
                ? days
                : new[] { DayOfWeek.Saturday, DayOfWeek.Sunday };
        }
    }
}
