using DeliverySystem.Models;
using DeliverySystem.Settings;
using Microsoft.Extensions.Configuration;

namespace DeliverySystem.Utils
{
    public class LoginScreen
    {
        List<SystemUser> systemUsers = [];

        string _pathSystemUsers = "";
        readonly string baseDir = AppContext.BaseDirectory;

        public LoginScreen(LoginScreenSettings settings)
        {
            _pathSystemUsers = Path.Combine(baseDir,settings.nameFileSystemUsers);
        }


        public void MainProgramm()
        {
            Console.WriteLine("ЛОГИН: ");
            string? inputLogin = Console.ReadLine();

            Console.WriteLine("ПАРОЛЬ: ");
            string? inputPassword = Console.ReadLine();
        }

        // public LoginScreen CreateAndLoadData()
        // {
        //     IConfigurationBuilder builder = new ConfigurationBuilder

        //     // if (!File.Exists(baseDir))
        //     //     return new();

        //     // return new();
        // }


    }
}