using System;
using System.Configuration;
using System.IO;


namespace dz8
{
   

    class Program
    {

        static void Main(string[] args)
        {

            string Name, Age, Hobbi;
            Configuration roaming = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = roaming.FilePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            Console.WriteLine(roaming.FilePath);
            if (File.Exists(roaming.FilePath))
            {
                Name = config.AppSettings.Settings["User"].Value;
                Age = config.AppSettings.Settings["Age"].Value;
                Hobbi = config.AppSettings.Settings["Hobbi"].Value;
                Console.WriteLine($"{Name}{Age}{Hobbi}");
            }
            else
            {
                Console.WriteLine("Введите Имя");
                Name = Console.ReadLine();
                Console.WriteLine("Введите возраст");
                Age = Console.ReadLine();
                Console.WriteLine("Введите ваш род деятельности");
                Hobbi = Console.ReadLine();
                config.AppSettings.Settings.Add("User", Name);
                config.AppSettings.Settings.Add("Age", Age);
                config.AppSettings.Settings.Add("Hobbi", Hobbi);
                config.Save();

            }

        }
    }

}