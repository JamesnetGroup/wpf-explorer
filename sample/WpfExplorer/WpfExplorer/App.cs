using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new Window();
        }
    }
}
