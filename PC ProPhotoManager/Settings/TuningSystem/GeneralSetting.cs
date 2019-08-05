using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace PC_ProPhotoManager.Settings.TuningSystem
{
    public class GeneralSetting : SettingsFile
    {
        private static GeneralSetting instance;

        public static GeneralSetting GetInstance()
        {
            if (instance == null)
            {
                instance = new GeneralSetting();
            }

            return instance;
        }

        private static INIManager manager;
        private readonly static string Name = "CustomSetting.ini";

        private GeneralSetting()
        {
            manager = new INIManager($"../../Settings/ConfigurationFile/{Name}");

            Initialization();
        }

        private string directoryPath;

        public string DirectoryPath
        {
            get
            {
                return directoryPath;
            }

            set
            {
                manager.WritePrivateString("Resources", "DirectoryPath", value);
                directoryPath = value;
            }
        }

        private void Initialization()
        {
            //INIManager manager = new INIManager($"{Path}/{Name}");

            if (File.Exists($"../../Settings/ConfigurationFile/{Name}")) //Здесь и начинается пакасть !!!
            {
                DirectoryPath = manager.GetPrivateString("Resources", "DirectoryPath");
            }
            else
            {
                File.Create($"../../Settings/ConfigurationFile/{Name}");

                manager.WritePrivateString("Resources", "DirectoryPath", " ");
            }
        }
    }
}
