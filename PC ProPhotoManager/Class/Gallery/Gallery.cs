using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PC_ProPhotoManager.Class.Gallery
{
    public class Gallery
    {
        private int ImageIndex { get; set; }

        private string DirectoryPath { get; set; } 
        private List<string> linksToPictures = new List<string>(); 

        public List<BitmapImage> images = new List<BitmapImage>();

        public Gallery(string directoryPath, ListBox listPhoto)
        {
            DirectoryPath = directoryPath;

            ImageIndex = 0;

            GetLinkToImages();
            GetImage();

            listPhoto.ItemsSource = images;
        }

        private void GetLinkToImages()
        {
            try
            {
                try
                {
                    linksToPictures = Directory.GetFiles(DirectoryPath, "*.jp*g").ToList();
                }
                catch(ArgumentException)
                {
                    MessageBox.Show("Не верный формат пути к каталогу", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch(DirectoryNotFoundException)
            {
                MessageBox.Show("Не найден/ы файл/ы!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GetImage()
        {
            for (int i = 0; i < linksToPictures.Count; i++)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(linksToPictures[i]));
                images.Add(bitmapImage);
            }
        }

        public BitmapImage Backward()
        {
            ImageIndex--;
            if (ImageIndex < 0)
            {
                ImageIndex = images.Count - 1;
            }

            return images[ImageIndex];
        }

        public BitmapImage Farther()
        {
            ImageIndex++;
            if (ImageIndex > images.Count - 1)
                ImageIndex = 0;

            return images[ImageIndex];
        }

        public void SaveSettings()
        {

        }
    }
}
