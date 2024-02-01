using Microsoft.Win32;
using System.Drawing;

namespace ImageEditor.View.Window
{
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenImage(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
                PictureBox.Image = new Bitmap(dialog.FileName);
        }
    }
}
