using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ProPhotoManager.Settings.TuningSystem.SettingFileClass
{
    public class GeneralSettingsFile
    {
        private static GeneralSettingsFile instance = null;

        private readonly string name = "GeneralSetting.ini";

        private GeneralSettingsFile()
        {

        }

        private string directoryPath;

        public static GeneralSettingsFile GetInstance()
        {
            if (instance == null)
            {
                instance = new GeneralSettingsFile();
            }

            return instance;
        }

        //private void Initialization()
        //{
        //    if (File.Exists($"../../Settings/ConfigurationFile/{Name}"))
        //    {
                
        //    }
        //    else
        //    {
        //        File.Create($"../../Settings/ConfigurationFile/{Name}");
        //    }
        //}
    }
}
