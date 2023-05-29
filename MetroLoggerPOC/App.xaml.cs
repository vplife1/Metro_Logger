using MetroLog.Maui;

namespace MetroLoggerPOC;

public partial class App : Application
{
	public App(MainPage mainPage)
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new NavigationPage(mainPage);

        LogController.InitializeNavigation(
            page => MainPage!.Navigation.PushModalAsync(page),
            () => MainPage!.Navigation.PopModalAsync());
    }
}
