using DeliverySystem.Models;
using DeliverySystem.Settings;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace DeliverySystem.Utils
{
    public class LoginScreen
    {
        List<SystemUser>? systemUsers = [];

        string _pathSystemUsers = "";
        readonly string baseDir = AppContext.BaseDirectory;


        public void MainProgramm()
        {
           LoadConfigData();

            Console.WriteLine("ЛОГИН: ");
            string? inputLogin = Console.ReadLine();

            Console.WriteLine("ПАРОЛЬ: ");
            string? inputPassword = Console.ReadLine();

            for (int i = 0; i < systemUsers.Count; i++)
            {
                if (inputLogin == systemUsers[i].Login)
                {
                    if (systemUsers[i].Password == inputPassword)
                    {
                        Console.Clear();
                        Console.WriteLine("Вход подтверждён");
                    }
                    
                }
            }


        }

        private void LoadConfigData() //!Добавить проверки
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(baseDir)
            .AddJsonFile("appsetting.json",optional: false, reloadOnChange: true);

            IConfigurationRoot config = builder.Build();

            string? _pathSystemUsers = config["PathInfo:pathLoginScreen"];
            _pathSystemUsers = Path.Combine(baseDir,_pathSystemUsers??""); //!Исправить

            string json = File.ReadAllText(_pathSystemUsers);

            systemUsers = JsonSerializer.Deserialize<List<SystemUser>>(json);

            
        }


    }
}