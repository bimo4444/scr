using Microsoft.Win32;
using scr.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace scr.cons
{
    class Program
    {
        static RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        static void Main(string[] args)
        {
            if(rkApp.GetValue("scr.cons") == null) 
                rkApp.SetValue(
                "scr.cons", 
                Assembly.GetExecutingAssembly().Location);
            
            Scroll s = new Scroll();
        }

    }
}
