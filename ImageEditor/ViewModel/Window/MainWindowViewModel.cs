using ImageEditor.Command;
using ImageEditor.View.Window;
using System.Windows;
using System.Windows.Input;

namespace ImageEditor.ViewModel.Window
{
    internal class MainWindowViewModel : ViewModelBase
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
            var extensionsWindow = new ExtensionsWindow();

            extensionsWindow.ShowDialog();
        }

        public MainWindowViewModel()
        {
            ExitCommand = new RelayCommand(canExit, exit);
            OpenExtensionsWindowCommand = new RelayCommand(canOpenExtensionsWindow, openExtensionsWindow);
        }
    }
}
