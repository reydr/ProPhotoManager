

namespace PC_ProPhotoManager.Settings.TuningSystem
{
    public class TuningSystem
    {
        private static TuningSystem instance = null;

        protected TuningSystem()
        {

        }

        public static TuningSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new TuningSystem();
            }

            return instance;
        }

        //protected string
    }
}
