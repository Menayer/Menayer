using Menayer.Extensions.Core;
using System.Globalization;
using Xunit;

namespace Menayer.Extensions.Tests.Extensions
{
    public class WeekendExtensionsTests
    {
        // Date constants chosen relative to 2025-11-26 (Wednesday):
        // 2025-11-29 => Saturday
        // 2025-11-30 => Sunday
        // 2025-11-28 => Friday

        [Fact]
        public void DateTime_IsWeekEnd_WithCulture_EnUS_SaturdaySunday()
        {
            var saturday = new DateTime(2025, 11, 29);
            var sunday = new DateTime(2025, 11, 30);
            var wednesday = new DateTime(2025, 11, 26);

            Assert.True(saturday.IsWeekEnd(new CultureInfo("en-US")));
            Assert.True(sunday.IsWeekEnd(new CultureInfo("en-US")));
            Assert.False(wednesday.IsWeekEnd(new CultureInfo("en-US")));
        }

        [Fact]
        public void DateTime_IsWeekEnd_WithCulture_AE_FridaySaturday()
        {
            var friday = new DateTime(2025, 11, 28);
            var sunday = new DateTime(2025, 11, 30);

            Assert.True(friday.IsWeekEnd(new CultureInfo("ar-EG"))); // EG uses Friday & Saturday
            Assert.False(sunday.IsWeekEnd(new CultureInfo("ar-EG")));
        }

        [Fact]
        public void DateTime_IsWeekEnd_WithStartWeekendDay_UsesCustomWindow()
        {
            var friday = new DateTime(2025, 11, 28);
            var saturday = new DateTime(2025, 11, 29);
            var sunday = new DateTime(2025, 11, 30);

            // Start at Friday, 2 days -> Friday & Saturday
            Assert.True(friday.IsWeekEnd(DayOfWeek.Friday, 2));
            Assert.True(saturday.IsWeekEnd(DayOfWeek.Friday, 2));
            Assert.False(sunday.IsWeekEnd(DayOfWeek.Friday, 2));

            // Start at Saturday, 1 day -> only Saturday
            Assert.True(saturday.IsWeekEnd(DayOfWeek.Saturday, 1));
            Assert.False(sunday.IsWeekEnd(DayOfWeek.Saturday, 1));
        }

        [Theory]
        [InlineData("Sunday")]
        [InlineData("sUnDaY")] // case-insensitive
        public void String_IsWeekEnd_WithCulture_ParsesDayNames_EnUS(string dayName)
        {
            Assert.True(dayName.IsWeekEnd(new CultureInfo("en-US")));
        }

        [Fact]
        public void String_IsWeekEnd_InvalidDayName_ReturnsFalse()
        {
            Assert.False("Funday".IsWeekEnd(new CultureInfo("en-US")));
        }

        [Fact]
        public void String_IsWeekEnd_WithStartWeekendDay_Works()
        {
            Assert.True("Friday".IsWeekEnd(DayOfWeek.Friday, 2)); // Friday & Saturday
            Assert.False("Sunday".IsWeekEnd(DayOfWeek.Friday, 2));
        }

        [Fact]
        public void DayOfWeek_IsWeekEnd_WithCulture_Works()
        {
            Assert.True(DayOfWeek.Saturday.IsWeekEnd(new CultureInfo("en-US")));
            Assert.False(DayOfWeek.Friday.IsWeekEnd(new CultureInfo("en-US")));

            // Iran uses Thursday & Friday
            Assert.True(DayOfWeek.Thursday.IsWeekEnd(new CultureInfo("fa-IR")));
            Assert.True(DayOfWeek.Friday.IsWeekEnd(new CultureInfo("fa-IR")));
            Assert.False(DayOfWeek.Saturday.IsWeekEnd(new CultureInfo("fa-IR")));
        }

        [Fact]
        public void DayOfWeek_IsWeekEnd_WithStartWeekendDay_Works()
        {
            Assert.True(DayOfWeek.Sunday.IsWeekEnd(DayOfWeek.Sunday, 1));
            Assert.False(DayOfWeek.Monday.IsWeekEnd(DayOfWeek.Sunday, 1));
            // 3-day weekend starting Thursday => Thu, Fri, Sat
            Assert.True(DayOfWeek.Thursday.IsWeekEnd(DayOfWeek.Thursday, 3));
            Assert.True(DayOfWeek.Saturday.IsWeekEnd(DayOfWeek.Thursday, 3));
            Assert.False(DayOfWeek.Sunday.IsWeekEnd(DayOfWeek.Thursday, 3));
        }

        [Fact]
        public void DateOnly_IsWeekEnd_WithCulture_And_WithStartWeekendDay_Works()
        {
            var saturday = DateOnly.FromDateTime(new DateTime(2025, 11, 29));
            var sunday = DateOnly.FromDateTime(new DateTime(2025, 11, 30));
            var friday = DateOnly.FromDateTime(new DateTime(2025, 11, 28));

            Assert.True(saturday.IsWeekEnd(new CultureInfo("en-US")));
            Assert.True(sunday.IsWeekEnd(new CultureInfo("en-US")));
            Assert.False(friday.IsWeekEnd(new CultureInfo("en-US")));

            // Custom: only Saturday (numberOfDays = 1)
            Assert.True(saturday.IsWeekEnd(DayOfWeek.Saturday, 1));
            Assert.False(sunday.IsWeekEnd(DayOfWeek.Saturday, 1));
        }
    }
}
