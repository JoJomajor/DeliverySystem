using DeliverySystem.Models;
using DeliverySystem.Service;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

//todo 1.Исправить хранение отнсотельного аддресса для папки с бд
//todo 2.Исправить технологию хранение пароля


namespace DeliverySystem.Service
{
    public class LoginScreen
    {
        ConsoleWriter consoleWriter = new();

        List<SystemUser> systemUsers = [];
        string? _pathSystemUsers;
        readonly string baseDir = AppContext.BaseDirectory;


        public void MainProgramm()
        {
            LoadConfigData();

            consoleWriter.WriteLoginScreen();

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
                        break;
                    }
                    
                }
            }


        }

        private void LoadConfigData()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(baseDir)
            .AddJsonFile("appsettings.json",optional: false, reloadOnChange: true);


            IConfigurationRoot config = builder.Build();
    

            _pathSystemUsers = config["FilePath:pathLoginScreen"];

            if (string.IsNullOrWhiteSpace(_pathSystemUsers))
                throw new ArgumentNullException(paramName: nameof(_pathSystemUsers), message: "Не удалось выделить значение из json.");

            _pathSystemUsers = Path.GetFullPath(Path.Combine(baseDir,_pathSystemUsers));

            if(!File.Exists(_pathSystemUsers))
                throw new FileNotFoundException(message: $"По указанному пути {_pathSystemUsers} файл с пользователям системы не обнаружен.");

            string json = File.ReadAllText(_pathSystemUsers);

            var option = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };


            systemUsers = JsonSerializer.Deserialize<List<SystemUser>>(json,option) ?? new List<SystemUser>();

            if(systemUsers.Count == 0)
                throw new ArgumentNullException(paramName: nameof(systemUsers), message: "Коллекция хранения пользователей системы не инициализирована корректно.");

        }


    }
}