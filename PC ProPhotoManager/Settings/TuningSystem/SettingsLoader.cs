using System;
using System.Collections;
using System.Collections.Generic;

namespace PC_ProPhotoManager.Settings.TuningSystem
{
    public class SettingsLoader
    {
        private static SettingsLoader instance = null;

        private static readonly INIManager manager;

        protected static readonly string Path = $"{AppDomain.CurrentDomain.BaseDirectory}/Settings/TuningSystem";

        private static readonly Hashtable FileLocation = new Hashtable();
        private readonly ICollection keys = FileLocation.Keys;

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
            FileLocation.Add("GeneralSetting", $"{Path}/{GeneralSetting.GetInstance()}");
        }
    }
}
