using System;
using System.Collections.Generic;
using System.IO;

namespace PC_ProPhotoManager.Settings.TuningSystem
{

    public class TuningSystem
    {
        private static readonly TuningSystem instance = new TuningSystem();

        private TuningSystem()
        {
            
        }

        public static TuningSystem GetInstance()
        {
            return instance;
        }
    }
}
