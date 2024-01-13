using Syncfusion.Maui.Core.Hosting;
using VivatInternship.Frontend.ViewModels;
using VivatInternship.Frontend.Views;

namespace VivatInternship.Frontend;

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
		//Views
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<LoadingPage>();

		//View Models
		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<LoadingPageViewModel>();

		return builder.Build();
	}
}
