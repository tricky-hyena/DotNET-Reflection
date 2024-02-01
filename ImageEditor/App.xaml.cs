using ImageEditor.View.Window;
using ImageEditor.ViewModel.Window;
using System.Windows;

namespace ImageEditor
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel()
            };

            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
