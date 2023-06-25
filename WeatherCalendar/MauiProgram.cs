﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace WeatherCalendar;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		try
		{
			CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Monday;
		}
		catch(Exception ex) 
		{
            Console.WriteLine(ex);
        }
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
