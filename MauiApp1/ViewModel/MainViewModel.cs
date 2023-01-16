using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp1.ViewModel;

public partial class MainViewModel : ObservableObject
{
    IConnectivity connectivity;
    public MainViewModel(IConnectivity connectivity)
    {
        Items = new ObservableCollection<string>();
        this.connectivity = connectivity;
    }

    [ObservableProperty] ObservableCollection<string> items;

    [ObservableProperty] string entryText;

    [RelayCommand]
    async Task Add()
    {
        if (string.IsNullOrWhiteSpace(EntryText)) return;
        if (connectivity.NetworkAccess != NetworkAccess.Internet)
        {
            await Shell.Current.DisplayAlert("Uh Oh!", "No Internet", "OK");
            return;
        }
        // add our item
        Items.Add(EntryText);
        EntryText = string.Empty;
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
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}"
            /* Se puede pasar un diccionario con los parámetros
             * en caso de ser objetos y no variables primitivas.
            ,new Dictionary<string, object>
            {

            }*/);
    }
}
