using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            CloseExistsProcess();
            this.Startup += App_Startup;
        }

        void CloseExistsProcess()
        {
            Process current = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    if (process.MainModule.FileName == current.MainModule.FileName)
                    {
                        process.Kill();
                    }
                }
            }
        }

        public static Point StartUpPosition = new Point();
        public static string test_p;


        void App_Startup(object sender, StartupEventArgs e)
        {
            try
            {
                test_p = e.Args[0];
                if (test_p == "true")
                {
                    
                }
            }
            catch {  }
            // MessageBox.Show("fail");
        }
    }
}
