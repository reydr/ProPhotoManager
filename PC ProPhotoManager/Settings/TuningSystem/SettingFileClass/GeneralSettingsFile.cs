using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_ProPhotoManager.Settings.TuningSystem;

namespace PC_ProPhotoManager.Settings.TuningSystem.SettingFileClass
{
    public class GeneralSettingsFile
    {
        private static GeneralSettingsFile instance = null;

        private readonly string name = "GeneralSetting.ini";

        private GeneralSettingsFile()
        {

        }

        public string directoryPath;

        private SettingsLoader settingsLoader = SettingsLoader.GetInstance();

        public static GeneralSettingsFile GetInstance()
        {
            if (instance == null)
            {
                instance = new GeneralSettingsFile();
            }

            return instance;
        }

        private void Initialization()
        {
            if (File.Exists($"../../Settings/ConfigurationFile/{name}"))
            {
                
            }
            else
            {
                File.Create($"../../Settings/ConfigurationFile/{name}");
            }
        }
    }
}
