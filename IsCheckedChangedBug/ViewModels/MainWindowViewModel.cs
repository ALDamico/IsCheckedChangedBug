using System;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace IsCheckedChangedBug.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    public MainWindowViewModel()
    {
        OnIsCheckedCmd = new AsyncRelayCommand<bool>(Execute);
        IsChecked = false;
        Text = "";
    }

    private Task Execute(bool arg)
    {
        Task.Delay(100);
        Text += Environment.NewLine + $"Arg is {arg}";
        return Task.Delay(100);
    }

    [ObservableProperty] private bool _isChecked;
    [ObservableProperty] private string _text;
    public ICommand OnIsCheckedCmd { get; }
}