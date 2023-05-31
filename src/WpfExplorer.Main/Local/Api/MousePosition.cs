using System.Windows;
using System.Windows.Input;
using dr = System.Drawing;

namespace WpfExplorer.Main.Local.Api
{
    public class MousePosition
    {
        public static dr.Point GetMousePosition(UIElement ui)
        {
            Point p = Mouse.GetPosition(Window.GetWindow(ui));
            Point ppp = Window.GetWindow(ui).PointToScreen(p);
            dr.Point pp = new((int)ppp.X, (int)ppp.Y);

            return pp;
        }
    }
}
