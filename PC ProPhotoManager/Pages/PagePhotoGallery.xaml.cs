using System.Windows.Controls;
using System.Runtime.InteropServices;

using PC_ProPhotoManager.Class.Gallery;

namespace PC_ProPhotoManager.Pages
{
    public partial class PagePhotoGallery : Page
    {
        private Gallery gallery;

        public PagePhotoGallery()
        {
            InitializeComponent();

            gallery = new Gallery(@"C:\Users\voron\Desktop\n", PhotoList); //Сделать Загрузку пути из ini файла
        }

        private void PhotoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
