using System;
using System.Collections.Generic;
using System.IO;

namespace PC_ProPhotoManager.Settings.TuningSystem
{

    public class TuningSystem
    {

        private static readonly TuningSystem instance = new TuningSystem();

        private TuningSystem() { }

        public static TuningSystem GetInstance()
        {
            return instance;
        }

        public FileStream customSetting { get; set; } = null;
            //new FileStream($"{AppDomain.CurrentDomain.BaseDirectory}/Settings/ConfigurationFile", FileMode.CreateNew);

        public static List<FileStream> ConfigurationFile = new List<FileStream>();

        private void Initialization()
        {

        }
    }
}
