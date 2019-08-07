using System.IO;

namespace PC_ProPhotoManager.Settings.TuningSystem
{
    public class GeneralSetting
    {
        private static GeneralSetting instance = null;

        public string DirectoryPath { get; set; }

        private GeneralSetting()
        {

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

        }
    }
}