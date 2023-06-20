using MauiMvvm.Pages;

namespace MauiMvvm;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage( new LoginPage());
	}
}
