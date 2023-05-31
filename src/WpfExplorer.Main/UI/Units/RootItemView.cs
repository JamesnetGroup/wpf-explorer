using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfExplorer.Main.UI.Units
{
    public class RootItemView : ListBox
    {
        static RootItemView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RootItemView), new FrameworkPropertyMetadata(typeof(RootItemView)));
        }

        public static readonly DependencyProperty DoubleClickCommandProperty = DependencyProperty.Register("DoubleClickCommand", typeof(ICommand), typeof(RootItemView));
        public static readonly DependencyProperty PreviewKeyDownCommandProperty = DependencyProperty.Register("PreviewKeyDownCommand", typeof(ICommand), typeof(RootItemView));

        public ICommand DoubleClickCommand
        {
            get => (ICommand)GetValue(DoubleClickCommandProperty);
            set => SetValue(DoubleClickCommandProperty, value);
        }

        public ICommand PreviewKeyDownCommand
        {
            get => (ICommand)GetValue(PreviewKeyDownCommandProperty);
            set => SetValue(PreviewKeyDownCommandProperty, value);
        }

        protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
        {
            base.OnMouseDoubleClick(e);

            if (e.OriginalSource is FrameworkElement fe && fe.DataContext.Equals(SelectedItem))
            {
                DoubleClickCommand?.Execute(SelectedItem);
            }
        }

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            PreviewKeyDownCommand?.Execute(e);
        }
    }
}
