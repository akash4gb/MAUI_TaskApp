
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiAppTest.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return;

        }

        Items.Add(Text);
        //Add our Item
        Text = string.Empty;
    }

}
