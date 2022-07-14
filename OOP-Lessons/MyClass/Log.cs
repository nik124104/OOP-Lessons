using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lessons
{
    public class Log
    {
        public static void Logs(string str)
        {

            File.AppendAllText("Log.txt", $" {Convert.ToString(new DateTime())} - {str} ; ");
        }
    }
}

