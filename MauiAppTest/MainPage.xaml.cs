using MauiAppTest.ViewModel;

namespace MauiAppTest;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}

	
}

