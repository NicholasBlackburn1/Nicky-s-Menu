using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;

namespace NickysMenu.utils
{
    public class logger
    {
       
        public static void info(string msg)
        {
            MelonLogger.Msg(ConsoleColor.Gray,msg);
        }
    }
}
