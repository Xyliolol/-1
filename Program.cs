using System;
using System.IO;
using Configuration;
using Resources;



namespace дз8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Resources.HelloWording);
            Console.WriteLine("Введите Имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string Age = Console.ReadLine();
            Console.WriteLine("Введите ваш род деятельности");
            string Hobbi = Console.ReadLine();
            Console.WriteLine($"{Name}\t{Age}\t{Hobbi}");
            Console.WriteLine(ConfigurationManager.AppSettings["User"]);
            Configuration roaming = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = roaming.FilePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("User", Console.ReadLine());
            config.Save();
            Console.WriteLine(roaming.FilePath);
            var User = config.AppSettings.Settings["User"].Value;
            Console.WriteLine(User);
            config.AppSettings.Settings["User"].Value = $"{User}_{ DateTime.Now}";
            config.Save();
            config.AppSettings.Settings.Add("User", Name);
            config.AppSettings.Settings.Add("User", Age);
            config.AppSettings.Settings.Add("User", Hobbi);
        }
    }
}
