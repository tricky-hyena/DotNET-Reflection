using Editor.Command;
using System.Windows;
using System.Windows.Input;

namespace Editor.ViewModel.Window
{
    class MainWindowViewModel : ViewModelBase
    {
        public ICommand ExitCommand { get; }

        private bool canExit(object parameter)
            => true;

        private void exit(object parameter)
            => Application.Current.Shutdown();

        public MainWindowViewModel()
        {
            ExitCommand = new RelayCommand(canExit, exit);
        }
    }
}
