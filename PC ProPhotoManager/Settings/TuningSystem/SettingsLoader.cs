using System;
using System.Collections;
using System.Collections.Generic;

namespace PC_ProPhotoManager.Settings.TuningSystem
{
    public class SettingsLoader
    {
        private static SettingsLoader instance = null;

        private static readonly string Path = $"{AppDomain.CurrentDomain.BaseDirectory}/Settings/TuningSystem";

        private readonly Hashtable FilesLocations = new Hashtable();
        private readonly INIManager manager;

        public static SettingsLoader GetInstance()
        {
            if (instance == null)
            {
                instance = new SettingsLoader();
            }

            return instance;
        }

        protected SettingsLoader()
        {
            Initialization();
        }

        private void Initialization()
        {
            FilesLocations.Add("GeneralSetting", $"{Path}/{GeneralSetting.GetInstance()}");
        }

        public string GetKey(string nameF, string key)
        {
            manager.Path = $"{Path}/{nameF}";

            return manager.GetPrivateString(nameF.Split('.')[0], key);
        }

        public void WriteStr(string nameF, string key, string section, string value)
        {
            manager.Path = $"{Path}/{nameF}";

            manager.WritePrivateString(section, key, value);
        }
    }
}
