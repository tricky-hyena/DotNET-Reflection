using Editor.View.Window;
using System.Windows;

namespace Editor;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow mainWindow = new();

        mainWindow.Show();

        base.OnStartup(e);
    }
}
