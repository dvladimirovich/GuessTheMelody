using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace GuessTheMelody
{
    /// <summary>
    /// Класс для передачи данных между формами
    /// </summary>
    internal static class Victorina
    {
        /// <summary>
        /// Список музыкальных композиций
        /// </summary>
        static public List<string> TrackList = new List<string>();
        /// <summary>
        /// Путь к последней выбранной папке.
        /// </summary>
        public static string LastFolder = string.Empty;
        /// <summary>
        /// Включать ли вложенные каталоги при загрузке треков. Значение по умолчанию - не включать
        /// </summary>
        public static bool AllDirectories = false;
        /// <summary>
        /// Начинать проигрывать композицию сначала или со случайного места. Значение по умолчанию - сначала
        /// </summary>
        public static bool RandomStart = false;
        /// <summary>
        /// Продолжительность игры. Значение по умолчанию - 60 секунд
        /// </summary>
        public static int GameDuration = 60;
        /// <summary>
        /// Продолжительность проигрывания трека. Значение по умолчанию - 10 секунд
        /// </summary>
        public static int MusicDuration = 10;

        /// <summary>
        /// Считать музыкальные композиции
        /// </summary>
        public static void ReadMusic()
        {
            try
            {
                string[] musicArray = Directory.GetFiles(LastFolder, "*.mp3", AllDirectories
                                                                                  ? SearchOption.AllDirectories
                                                                                  : SearchOption.TopDirectoryOnly);
                TrackList.Clear();
                TrackList.AddRange(musicArray);
            }
            catch {}
        }

        private static string regKeyName = @"Software\MyCompanyName\GuessTheMelody";

        /// <summary>
        /// Сохраняет настройки приложения в реестр
        /// </summary>
        public static void SaveParam()
        {
            RegistryKey regkey = null;
            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (regkey == null) return;
                regkey.SetValue("LastFolder", LastFolder);
                regkey.SetValue("AllDirectories", AllDirectories);
                regkey.SetValue("RandomStart", RandomStart);
                regkey.SetValue("GameDuration", GameDuration);
                regkey.SetValue("MusicDuration", MusicDuration);
            }
            finally 
            {
                if (regkey != null) regkey.Close();
            }
        }

        /// <summary>
        /// Считывает настройки приложения из реестра
        /// </summary>
        public static void ReadParam()
        {
            RegistryKey regkey = null;
            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (regkey == null) return;
                LastFolder = (string) regkey.GetValue("LastFolder", "");
                AllDirectories = Convert.ToBoolean(regkey.GetValue("AllDirectories", false));
                RandomStart = Convert.ToBoolean(regkey.GetValue("RandomStart", false));
                GameDuration = (int) regkey.GetValue("GameDuration", 60);
                MusicDuration = (int) regkey.GetValue("MusicDuration", 10);
            }
            finally
            {
                if (regkey != null) regkey.Close();
            }
        }
    }
}
