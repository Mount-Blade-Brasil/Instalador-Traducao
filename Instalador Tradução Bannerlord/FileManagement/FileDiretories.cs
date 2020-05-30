using System.Collections.Generic;

namespace Instalador_Tradução_Bannerlord.FileManagement
{
    public class FileDiretories
    {
        public static List<string> Get()
        {
            return new List<string>()
            {
                "Modules\\Native\\ModuleData\\Languages\\PTBR",
                "Modules\\SandBox\\ModuleData\\Languages\\PTBR",
                "Modules\\SandBoxCore\\ModuleData\\Languages\\PTBR",
                "Modules\\StoryMode\\ModuleData\\Languages\\PTBR",
                "GUI\\GauntletUI\\Fonts",
                "GUI\\Launcher\\Fonts"
            };
        }
    }
}