using System;
using System.IO;
using System.Linq;

namespace Instalador_Tradução_Bannerlord.FileManagement
{
    public class FileManager
    {
        public static void DeleteFiles(string baseDiretory)
        {
            foreach (var fileDiretory in FileDiretories.Get().OrderBy(x => x))
            {
                var directoryInfo = new DirectoryInfo($"{baseDiretory}\\{fileDiretory}");

                if (directoryInfo.Exists)
                    foreach (FileInfo file in directoryInfo.GetFiles("*.xml"))
                        file.Delete();
            }
        }

        public static void CopyFiles(string baseDiretory, string outputDirectory)
        {
            CheckGameDirectory(outputDirectory);

            foreach (var fileDiretory in FileDiretories.Get().OrderBy(x => x))
            {
                var directoryInfo = new DirectoryInfo($"{baseDiretory}\\{fileDiretory}");
                var files = directoryInfo.GetFiles("*.xml");

                foreach (FileInfo file in files.OrderBy(x => x.Name))
                {
                    var outputFileDirectory = $"{outputDirectory}\\{fileDiretory}";
                    Directory.CreateDirectory(outputFileDirectory);
                    File.Copy($"{baseDiretory}\\{fileDiretory}\\{file.Name}", $"{outputFileDirectory}\\{file.Name}", true);
                }
            }
        }

        public static void DeleteConfigFiles()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Mount and Blade II Bannerlord\\Configs";
            var directoryInfo = new DirectoryInfo(path);

            if (directoryInfo.Exists)
                foreach (FileInfo file in directoryInfo.GetFiles("."))
                    file.Delete();
        }

        private static void CheckGameDirectory(string outputDirectory)
        {
            foreach (var fileDiretory in FileDiretories.Get().OrderBy(x => x))
            {
                var directoryInfo = new DirectoryInfo($"{outputDirectory}\\{fileDiretory.Replace("PTBR", "")}");

                if (!directoryInfo.Exists)
                    throw new Exception();
            }
        }
    }
}