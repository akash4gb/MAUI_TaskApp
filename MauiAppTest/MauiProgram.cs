using MauiAppTest.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppTest;

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

		//Main Page
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();
		
		//Detail Page
		builder.Services.AddTransient<DetailPage>();
		builder.Services.AddTransient<DetailViewModel>();


		return builder.Build();
	}
}
