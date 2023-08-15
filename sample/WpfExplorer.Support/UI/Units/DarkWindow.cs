using Jamesnet.Wpf.Controls;
using System.Windows;

namespace WpfExplorer.Support.UI.Units
{
    public class DarkWindow : JamesWindow
    {
        public static readonly DependencyProperty LocationTemplateProperty = DependencyProperty.Register("LocationTemplate", typeof(DataTemplate), typeof(DarkWindow), new UIPropertyMetadata(null));
        public static readonly DependencyProperty LocationProperty = DependencyProperty.Register("Location", typeof(object), typeof(DarkWindow), new UIPropertyMetadata(null));
        
        public DataTemplate LocationTemplate
        {
            get => (DataTemplate)GetValue(LocationTemplateProperty);
            set => SetValue(LocationTemplateProperty, value);
        }

        public object Location
        {
            get => (object)GetValue(LocationTemplateProperty);
            set => SetValue(LocationTemplateProperty, value);
        }

        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow), new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }
    }
}
