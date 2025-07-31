using System;
using Xunit;
using Menayer.Core.Extensions;

namespace Menayer.Core.Tests.Extensions
public class DateTimeExTests
{
    [Fact]
    public void GetCountryCodeFromCulture_ReturnsExpectedCode()
    {
        var originalCulture = CultureInfo.CurrentCulture;

        try
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            var result = DateTimeExtensions.GetCountryCodeFromCulture();
            Assert.Equal("US", result);
        }
        finally
        {
            CultureInfo.CurrentCulture = originalCulture;
        }
    }

    [Fact]
    public void GetCountryCodeFromCulture_ReturnsNull_OnInvalidCulture()
    {
        var originalCulture = CultureInfo.CurrentCulture;

        try
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var result = DateTimeExtensions.GetCountryCodeFromCulture();
            Assert.Null(result);
        }
        finally
        {
            CultureInfo.CurrentCulture = originalCulture;
        }
    }
}