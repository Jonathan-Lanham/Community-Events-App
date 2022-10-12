﻿using CommunityEventsMAUI.ViewModels;
using CommunityEventsMAUI.Views;

namespace CommunityEventsMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<IMap>(Map.Default);

        builder.Services.AddSingleton<EventCreationPage>();
		builder.Services.AddSingleton<EventInfoPage>();
		builder.Services.AddSingleton<EventPage>();
		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<ProfilePage>();
		builder.Services.AddSingleton<SettingsPage>();

		builder.Services.AddTransient<HomePageModel>();
        builder.Services.AddTransient<EventCreationPageModel>();
        builder.Services.AddTransient<EventInfoPageModel>();
        builder.Services.AddTransient<EventPageModel>();
        builder.Services.AddTransient<LoginPageModel>();
        builder.Services.AddTransient<ProfilePageModel>();
        builder.Services.AddTransient<SettingsPageModel>();

        return builder.Build();
	}
}
// a person with experience is never at the mercy to a person as a theory - Mentor of Sekol's