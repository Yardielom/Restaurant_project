using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1.Utils
{
    public static class DataStorage
    {
        private static readonly string ProjectFolder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

        private static readonly string DataFolder = Path.Combine(ProjectFolder, "data");


        private static void EnsureDataFolderExists()
        {
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }
        }

        public static void SaveToFile<T>(List<T> items, string fileName)
        {
            EnsureDataFolderExists();

            var fullPath = Path.Combine(DataFolder, fileName);
            var json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(fullPath, json);
        }

        public static List<T> LoadFromFile<T>(string fileName)
        {
            EnsureDataFolderExists();

            var fullPath = Path.Combine(DataFolder, fileName);

            if (!File.Exists(fullPath))
            {
                return new List<T>();
            }

            var json = File.ReadAllText(fullPath);
            return JsonSerializer.Deserialize<List<T>>(json);
        }
    }
}
