using System.Windows;
using System.IO;

using MahApps.Metro.Controls;

using PC_ProPhotoManager.Class;

namespace PC_ProPhotoManager
{

    public partial class MainWindow : MetroWindow
    {

        public MainWindow()
        {
            InitializeComponent();

            WindowState = WindowState.Maximized;

            //INIManager manager = new INIManager(@"my.ini");
            FileInfo file = new FileInfo(@"..\..\Settings\Gallery.ini");

            if (!file.Exists)
            {
                StreamWriter sw = file.CreateText();
            }
        }
    }
}
