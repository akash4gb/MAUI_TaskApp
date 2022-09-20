﻿
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiAppTest.ViewModel;

public partial class MainViewModel : ObservableObject
{

    IConnectivity connectivity;
    public MainViewModel(IConnectivity connectivity)
    {
        Items = new ObservableCollection<string>();
        this.connectivity = connectivity;
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task AddAsync()
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return;
        }

        if (connectivity.NetworkAccess != NetworkAccess.Internet)
        {
            await Shell.Current.DisplayAlert("Uh oh!", "No Internet", "OK");
            return;
        }

        Items.Add(Text);
        //Add our Item
        Text = string.Empty;
    }


    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    [RelayCommand]
   async Task Tap(string s) 
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?TextId={s}");
    }
}
