using System.Windows;
using System.Windows.Controls;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Location.UI.Units
{
    public class LocatorButton : Button
    {
        public static readonly DependencyProperty ActionTypeProperty = DependencyProperty.Register("ActionType", typeof(ActionType), typeof(LocatorButton), new PropertyMetadata(ActionType.Up));

        public ActionType ActionType
        {
            get => (ActionType)GetValue(ActionTypeProperty);
            set => SetValue(ActionTypeProperty, value);
        }

        static LocatorButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LocatorButton), new FrameworkPropertyMetadata(typeof(LocatorButton)));
        }
    }
}
