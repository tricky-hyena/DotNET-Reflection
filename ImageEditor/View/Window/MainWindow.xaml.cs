using API;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ImageEditor.View.Window
{
    public partial class MainWindow : System.Windows.Window
    {
        private Dictionary<string, IImageEditorExtension> extensions = new Dictionary<string, IImageEditorExtension>();

        public MainWindow()
        {
            InitializeComponent();

            initializeExtensions();

            foreach (IImageEditorExtension p in extensions.Values)
            {
                var menuItem = new System.Windows.Controls.MenuItem()
                {
                    Header = p.Title
                };
                menuItem.Visibility = Visibility.Visible;
                menuItem.Click += OnPluginClick;
                Tools.Items.Add(menuItem);
            }
        }

        private void OpenImage(object sender, System.Windows.RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();

            if (dialog.ShowDialog() == true)
                PictureBox.Image = new Bitmap(dialog.FileName);
        }

        private void initializeExtensions()
        {
            string folder = System.AppDomain.CurrentDomain.BaseDirectory;

            string[] files = Directory.GetFiles(folder, "*.dll");

            foreach (string file in files)
                try
                {
                    Assembly assembly = Assembly.LoadFile(file);

                    foreach (Type type in assembly.GetTypes())
                    {
                        Type iface = type.GetInterface("API.IImageEditorExtension");

                        if (iface != null)
                        {
                            IImageEditorExtension plugin = (IImageEditorExtension)Activator.CreateInstance(type);
                            extensions.Add(plugin.Title, plugin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                }
        }

        public void OnPluginClick(object sender, EventArgs e)
        {
            IImageEditorExtension plugin = extensions[((System.Windows.Controls.MenuItem)sender).Header as string];
            PictureBox.Image = plugin.Transform((Bitmap)PictureBox.Image);
            PictureBox.Refresh();
        }
    }
}
