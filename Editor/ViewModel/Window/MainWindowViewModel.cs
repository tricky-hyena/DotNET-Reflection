using Editor.Command;
using Editor.View.Window;
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

        public ICommand OpenExtensionsWindowCommand { get; set; }

        private bool canOpenExtensionsWindow(object parameter)
            => true;

        private void openExtensionsWindow(object parameter)
        {
            ExtensionsWindow extensionsWindow = new();

            extensionsWindow.ShowDialog();
        }

        public MainWindowViewModel()
        {
            ExitCommand = new RelayCommand(canExit, exit);
            OpenExtensionsWindowCommand = new RelayCommand(canOpenExtensionsWindow, openExtensionsWindow);
        }
    }
}
