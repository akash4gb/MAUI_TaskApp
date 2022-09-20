using MauiAppTest.ViewModel;

namespace MauiAppTest;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainPage vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	
}

