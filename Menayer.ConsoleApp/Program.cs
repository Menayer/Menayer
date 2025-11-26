// See https://aka.ms/new-console-template for more information
using Menayer.Extensions.Core;
using System.Globalization;

//Console.WriteLine("Hello, World!");
//Console.WriteLine(WeekExtensions.IsWeekEnd(DateTime.Now, null));
Console.WriteLine(
WeekExtensions.IsWeekEnd(DateTime.Now, new CultureInfo("ar-EG")));
