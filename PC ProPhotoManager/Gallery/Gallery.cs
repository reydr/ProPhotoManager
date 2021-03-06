﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PC_ProPhotoManager.Class.Gallery
{
    public class Gallery
    {
        private static readonly Gallery instance = new Gallery(DirectoryPath, ListPhoto);

        private int ImageIndex { get; set; }

        private static string DirectoryPath { get; set; }

        public List<string> LinksToPictures { get; private set; } = new List<string>();
        public List<BitmapImage> images = new List<BitmapImage>();

        private static ListBox ListPhoto { get; set; }

        public Gallery(string directoryPath, ListBox listPhoto)
        {
            Initialization(directoryPath, listPhoto);
        }

        public static Gallery GetInstance(string directoryPath, ListBox listPhoto)
        {
            DirectoryPath = directoryPath;
            ListPhoto = listPhoto;

            return instance;
        }

        private void Initialization(string directoryPath, ListBox listPhoto)
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
                    LinksToPictures = Directory.GetFiles(DirectoryPath, "*.jp*g").ToList();
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
            foreach (var i in LinksToPictures)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(i));

                Image image = new Image();

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
            {
                ImageIndex = 0;
            }

            return images[ImageIndex];
        }
    }
}