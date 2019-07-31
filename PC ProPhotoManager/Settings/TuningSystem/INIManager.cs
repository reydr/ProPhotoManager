﻿
//  Встроенные библиотеки
using System.Runtime.InteropServices;
using System.Text;

namespace PC_ProPhotoManager.Settings.TuningSystem
{

    public sealed class INIManager
    {
        //  Конструктор, принимающий путь к INI-файлу
        public INIManager(string aPath)
        {

            path = aPath;
        }

        //  Конструктор без аргументов (путь к INI-файлу нужно будет задать отдельно)
        public INIManager() : this("") { }

        //  Поля класса
        private const int SIZE = 1024; //   Максимальный размер (для чтения значения из файла)
        private string path = null; //  Для хранения пути к INI-файлу

        //  Возвращает или устанавливает путь к INI файлу
        public string Path { get { return path; } set { path = value; } }

        //  Возвращает значение из INI-файла (по указанным секции и ключу) 
        public string GetPrivateString(string aSection, string aKey)
        {

            //  Для получения значения
            StringBuilder buffer = new StringBuilder(SIZE);

            //  Получить значение в buffer
            GetPrivateString(aSection, aKey, null, buffer, SIZE, path);

            //  Вернуть полученное значение
            return buffer.ToString();
        }

        //  Пишет значение в INI-файл (по указанным секции и ключу) 
        public void WritePrivateString(string aSection, string aKey, string aValue)
        {

            //  Записать значение в INI-файл
            WritePrivateString(aSection, aKey, aValue, path);
        }

        //  Импорт функции GetPrivateProfileString (для чтения значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateString(string section, string key, string def, StringBuilder buffer, int size, string path);

        //  Импорт функции WritePrivateProfileString (для записи значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern int WritePrivateString(string section, string key, string str, string path);
    }
}
