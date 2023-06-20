namespace MauiMvvm.Pages;

using MauiMvvm.Services;
using MauiMvvmLibrary.ViewModels;

public partial class LoginPage : ContentPage
{
    private readonly LoginViewModel _viewModel;
    private readonly Navigation _navigation;
    public LoginPage()
	{
		InitializeComponent();
        _navigation = new Navigation() { Namespace = "MauiMvvm.Pages" };
        BindingContext = _viewModel = new LoginViewModel(_navigation);
	}

    private void Login_Clicked(object sender, EventArgs e)
    {
        _viewModel.Login();
    }
}