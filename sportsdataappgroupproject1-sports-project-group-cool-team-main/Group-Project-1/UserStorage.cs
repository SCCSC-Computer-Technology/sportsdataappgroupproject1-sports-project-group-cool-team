using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Group_Project_1
{
    public static class UserStorage
    {
        private static readonly string folder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                         "Group_Project_1");

        private static readonly string file =
            Path.Combine(folder, "users.json");

        public static List<User> LoadUsers()
        {
            if (!File.Exists(file))
                return new List<User>();

            string json = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<List<User>>(json)
                   ?? new List<User>();
        }

        public static void SaveUsers(List<User> users)
        {
            Directory.CreateDirectory(folder);

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);

            File.WriteAllText(file, json);
        }
    }
}