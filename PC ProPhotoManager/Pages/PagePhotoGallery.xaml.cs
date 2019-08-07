using System.Windows.Controls;

using PC_ProPhotoManager.Gallery;
using PC_ProPhotoManager.Settings.TuningSystem;


namespace PC_ProPhotoManager.Pages
{
    public partial class PagePhotoGallery : Page
    {
        public PagePhotoGallery()
        {
            InitializeComponent();

            //GeneralSetting generalSetting = GeneralSetting.GetInstance();

            //Gallery gallery = Gallery.GetInstance(generalSetting.DirectoryPath, PhotoList);

            //PhotoList.ItemsSource = gallery.images;

           // SettingsFile.GeneralSetting generalSetting = SettingsFile.GeneralSetting.GetInstance();
        }

        private void PhotoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
