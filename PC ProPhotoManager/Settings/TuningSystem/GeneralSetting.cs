using System.IO;
using PC_ProPhotoManager.Settings.TuningSystem.SettingFileClass;

namespace PC_ProPhotoManager.Settings.TuningSystem
{
    public class GeneralSetting 
    {
        private static GeneralSetting instance = null;

        public string DirectoryPath { get; set; }

        private readonly GeneralSettingsFile generalSettingsFile = GeneralSettingsFile.GetInstance();

        private GeneralSetting()
        {
            Initialization();
        }

        public static GeneralSetting GetInstance()
        {
            if (instance == null)
            {
                instance = new GeneralSetting();
            }

            return instance;
        }

        private void Initialization()
        {
            DirectoryPath = generalSettingsFile.directoryPath;
        }
    }
}