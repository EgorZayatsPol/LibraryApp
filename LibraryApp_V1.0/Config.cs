using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Config
    {
        public static string LibraryName;
        public static string Version;

        static Config()
        {
            LibraryName = "City public library";
            Version = "1.0.0";
        }
    }
}
