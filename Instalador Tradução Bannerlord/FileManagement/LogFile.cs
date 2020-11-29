using System;
using System.IO;

namespace Instalador_Tradução_Bannerlord.FileManagement
{
    public class LogFile
    {
        public static void AddLog(string message, Exception exception)
        {
            using (var writer = new StreamWriter($"error_log.txt", true))
            {
                writer.WriteLine($"[{DateTime.Now}]: {message}");
                writer.WriteLine();
                writer.WriteLine($"Exception Message: {exception.Message}");
                writer.WriteLine($"Exception StackTrace: {exception.StackTrace}");
                writer.WriteLine("__________________________________________________");
                writer.WriteLine();
                writer.Close();
            }
        }
    }
}
