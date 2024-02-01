
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Editor.ViewModel;

abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(propertyName, new PropertyChangedEventArgs(propertyName));
    }
}
