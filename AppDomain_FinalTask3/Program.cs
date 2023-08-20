using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDomain_FinalTask3
{
    internal static class Program
    {
        static AppDomain ControlWinAppDomain;
        static AppDomain ButtonWinAppDomain;
        static Assembly ControlWinAssembly;
            static Assembly ButtonWinAssembly;
        static Module ControlWinModule;
        static Module ButtonWinModule;
        static Form ControlWinForm; 
        static Form ButtonWinForm;
        [LoaderOptimization(LoaderOptimization.MultiDomain)]

        static void Main()
        {
             
            Application.EnableVisualStyles();
            ControlWinAppDomain = AppDomain.CreateDomain("Control Window");
            ButtonWinAppDomain = AppDomain.CreateDomain("Button Window");

            ControlWinAssembly = ControlWinAppDomain.Load(AssemblyName.GetAssemblyName("ControlButton.exe"));
            ButtonWinAssembly = ButtonWinAppDomain.Load(AssemblyName.GetAssemblyName("Button.exe"));

            ControlWinModule = ControlWinAssembly.GetModule("ControlButton.exe");
            ButtonWinModule = ButtonWinAssembly.GetModule("Button.exe");

          


            Type t2 = ButtonWinModule.GetType("Button.Form1");
            ButtonWinForm = (Form)Activator.CreateInstance(t2, null);
            new Thread(new ThreadStart(() => { ButtonWinForm.ShowDialog(); })).Start();

            Type t1 = ControlWinModule.GetType("ControlButton.Form1");
            ControlWinForm = (Form)(Activator.CreateInstance(t1, ButtonWinModule ,ButtonWinForm  ));
            new Thread(new ThreadStart(() =>
            {
                while (!ButtonWinForm.Visible) 
                {
                    Thread.Sleep(1000);
                }
                ControlWinForm.ShowDialog();
                if (ButtonWinForm.Visible) ButtonWinForm.Invoke(new Action(() =>
                {
                    ButtonWinForm.Close();
                })); 
              
            })).Start();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
