
/**
 * this class is for loggging all Info to the console and sets them visable from the other logs 
 */
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


        public static void warning(string msg)
        {
            MelonLogger.Msg(ConsoleColor.Yellow,msg);
        }

        public static void error(string msg)
        {
            MelonLogger.Msg(ConsoleColor.Red,msg);
        }

        public static void ok(string msg)
        {
            MelonLogger.Msg(ConsoleColor.Green,msg);
        }

        public static void data(string msg)
        {
            MelonLogger.Msg(ConsoleColor.Magenta,msg);
        }
    }
}
