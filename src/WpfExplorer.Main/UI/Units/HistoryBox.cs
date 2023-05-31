using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfExplorer.Main.Local.Model;

namespace WpfExplorer.Main.UI.Units
{
    public class HistoryBox : ComboBox
    {
        static HistoryBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HistoryBox), new FrameworkPropertyMetadata(typeof(HistoryBox)));
        }

        public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(HistoryBox));

        public ICommand SelectionCommand
        {
            get => (ICommand)GetValue(SelectionCommandProperty);
            set => SetValue(SelectionCommandProperty, value);
        }

        protected override void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonUp(e);

            if (IsDropDownOpen && e.OriginalSource is FrameworkElement fe && fe.DataContext is FileModel root)
            {
                SelectionCommand.Execute(root);
            }
        }
    }
}
