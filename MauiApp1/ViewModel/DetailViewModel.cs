using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModel;

// [QueryProperty(cualquier nombre, el nombre exacto de lo que se va a recibir)]
[QueryProperty("Text", "Text")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;
}
