using Editor.View.Window;
using Editor.ViewModel.Window;
using System.Windows;

namespace Editor;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow mainWindow = new()
        {
            DataContext = new MainWindowViewModel()
        };

        mainWindow.Show();

        base.OnStartup(e);
    }
}
