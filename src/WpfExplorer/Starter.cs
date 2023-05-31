using System;
using WpfExplorer.Properties;

namespace WpfExplorer
{
    public class Starter
    {
        [STAThread]
        public static void Main()
        {
            _ = new App()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
