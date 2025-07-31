namespace Menayer.Core.Extensions;
public static class DateTimeEx
{
    /// <summary>
    /// A read-only dictionary mapping a country's two-letter code to its weekend days.
    /// </summary>
    private static readonly Dictionary<string, HashSet<DayOfWeek>> CountryWeekends = new(StringComparer.OrdinalIgnoreCase)
    {
        { "AE", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // United Arab Emirates
        { "AR", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Argentina
        { "AT", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Austria
        { "AU", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Australia
        { "BD", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Bangladesh
        { "BE", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Belgium
        { "BR", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Brazil
        { "CA", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Canada
        { "CH", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Switzerland
        { "CL", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Chile
        { "CN", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // China
        { "CO", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Colombia
        { "DE", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Germany
        { "DK", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Denmark
        { "EG", new() { DayOfWeek.Friday, DayOfWeek.Saturday } }, // Egypt
        { "ES", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Spain
        { "FI", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Finland
        { "FR", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // France
        { "GB", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // United Kingdom
        { "GR", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Greece
        { "ID", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Indonesia
        { "IE", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Ireland
        { "IN", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // India
        { "IR", new() { DayOfWeek.Thursday, DayOfWeek.Friday } }, // Iran
        { "IT", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Italy
        { "JO", new() { DayOfWeek.Friday, DayOfWeek.Saturday } }, // Jordan
        { "JP", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Japan
        { "KR", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // South Korea
        { "KW", new() { DayOfWeek.Friday, DayOfWeek.Saturday } }, // Kuwait
        { "MX", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Mexico
        { "MY", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Malaysia
        { "NG", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Nigeria
        { "NL", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Netherlands
        { "NO", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Norway
        { "NZ", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // New Zealand
        { "OM", new() { DayOfWeek.Friday, DayOfWeek.Saturday } }, // Oman
        { "PE", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Peru
        { "PH", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Philippines
        { "PK", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Pakistan
        { "PL", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Poland
        { "PS", new() { DayOfWeek.Friday, DayOfWeek.Saturday } }, // Palestine
        { "PT", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Portugal
        { "QA", new() { DayOfWeek.Friday, DayOfWeek.Saturday } }, // Qatar
        { "RU", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Russia
        { "SA", new() { DayOfWeek.Friday, DayOfWeek.Saturday } }, // Saudi Arabia
        { "SE", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Sweden
        { "TH", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Thailand
        { "TR", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // Turkey
        { "US", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // United States
        { "ZA", new() { DayOfWeek.Saturday, DayOfWeek.Sunday } }, // South Africa
    };
    /// <summary>
    /// Detect Country from local.
    /// </summary>
    /// <returns>The two-letter ISO country code.</returns>
    internal static string? GetCountryCodeFromCulture()
    {
        try
        {
            var culture = CultureInfo.CurrentCulture;
            if (!culture.IsNeutralCulture)
            {
                var region = new RegionInfo(culture.Name);
                return region.TwoLetterISORegionName;
            }
        }
        catch
        {
            return null;
        }

        return null;
    }

    /// <summary>
    /// Checks if the date falls on a weekend day based on country-specific rules.
    /// </summary>
    /// <param name="date">The data to check.</param>
    /// <param name="countryCode">The two-letter ISO country code.</param>
    /// <returns>True if the day is a weekend, otherwise false.</returns>
    public static bool IsWeekend(this DateTime date, string? countryCode = null)
    {
        
    }
    
}