using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfExplorer.Main.UI.Views;

namespace WpfExplorer
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new Finder();
        }
    }
}
