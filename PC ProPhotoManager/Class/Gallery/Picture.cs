using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace PC_ProPhotoManager.Class.Gallery
{
    public sealed class Picture : Gallery
    {
        public Picture(string directoryPath, ListBox listPhoto) : base(directoryPath, listPhoto) { }
    }
}
