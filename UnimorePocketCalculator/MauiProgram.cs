using Microsoft.AspNetCore.Components.WebView.Maui;
using UnimorePocketCalculator.Data;
using MudBlazor.Services;

namespace UnimorePocketCalculator;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddMudServices();
		builder.Services.AddSingleton<GuageChartService>();

		return builder.Build();
	}
}
