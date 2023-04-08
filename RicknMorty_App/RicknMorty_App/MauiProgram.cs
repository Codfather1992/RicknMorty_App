using Microsoft.Extensions.Logging;
using RicknMorty_App.ViewModels;
using RicknMorty_App.Views;

namespace RicknMorty_App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiMicroMvvm<AppShell>("Resources/Styles/Colors.xaml", "Resources/Styles/Styles.xaml")
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
			builder.Services.MapView<MainPage, MainPageViewModel>();
            builder.Services.MapView<TestPage, TestPageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        Routing.RegisterRoute("testpage", typeof(TestPage));
        return builder.Build();
	}
}
