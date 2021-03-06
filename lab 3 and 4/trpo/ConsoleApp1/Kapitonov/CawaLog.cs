using ConsoleApp1.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitonov
{
    class CawaLog : LogAbstract, LogInterface
    {
        private static CawaLog i = null;

        public static CawaLog I()
        {
            if (i == null)
            {
                i = new CawaLog();
            }

            return i;
        }

        private CawaLog() { }

        List<string> logs = new List<string>();

        public LogInterface log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
    }
}
