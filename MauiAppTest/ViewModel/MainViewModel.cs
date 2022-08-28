
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace MauiAppTest.ViewModel;

public partial class MainViewModel : ObservableObject
{
    

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        //Add our Item
        Text = text;
    }

}
