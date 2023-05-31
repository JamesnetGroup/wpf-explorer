using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExplorer
{
    public class Starter
    {
        [STAThread]
        public static void Main()
        {
            App app = new();
            app.Run();
        }
    }
}
