using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] ObservableCollection<string> lists;

        public MainViewModel()
        {
            Lists = new ObservableCollection<string>();
        }
    }
}
