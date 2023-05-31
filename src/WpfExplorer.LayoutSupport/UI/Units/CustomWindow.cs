using Jamesnet.Wpf.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfExplorer.LayoutSupport.UI.Units
{
    public class ViewOptionModel
    {
        public int LocX { get; set; }
        public int LocY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class MenuModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }

        public ICommand MenuClickCommand { get; set; }
    }

    public class CustomWindow : JamesWindow
    {
        static CustomWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomWindow), new FrameworkPropertyMetadata(typeof(CustomWindow)));
        }

        public static readonly DependencyProperty TitleTemplateProperty = DependencyProperty.Register("TitleTemplate", typeof(DataTemplate), typeof(CustomWindow), new PropertyMetadata(null));
        public static readonly DependencyProperty SubTitleProperty = DependencyProperty.Register("SubTitle", typeof(object), typeof(CustomWindow), new PropertyMetadata(null));

        protected bool IsFixedSize;
        protected MenuModel MenuInfo;


        public DataTemplate TitleTemplate
        {
            get => (DataTemplate)GetValue(TitleTemplateProperty);
            set => SetValue(TitleTemplateProperty, value);
        }

        public object SubTitle
        {
            get => GetValue(SubTitleProperty);
            set => SetValue(SubTitleProperty, value);
        }

        public CustomWindow()
        {
            WindowStyle = WindowStyle.None;
            ResizeMode = ResizeMode.CanResize;
            AllowsTransparency = true;
        }

        public override void OnApplyTemplate()
        {
            if (GetTemplateChild("PART_CloseButton") is Button btn)
            {
                btn.Click += (s, e) => Close();
            }
            if (GetTemplateChild("PART_DragBar") is DraggableBar bar)
            {
                bar.MouseDown += WindowDragMove;
            }
        }

        public void OnShow(MenuModel menu)
        {
            MenuInfo = menu;
            Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void WindowDragMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                GetWindow(this).DragMove();
            }
        }
    }
}
