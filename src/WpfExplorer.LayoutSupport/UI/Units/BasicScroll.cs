﻿using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.LayoutSupport.UI.Units
{
    public class BasicScroll : ScrollViewer
    {
        static BasicScroll()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BasicScroll), new FrameworkPropertyMetadata(typeof(BasicScroll)));
        }
    }
}
