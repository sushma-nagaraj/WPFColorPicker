using System;
using System.Windows.Media;

namespace WPFColorPicker
{
    public class DialogEventArgs : EventArgs
    {
        public DialogResult DialogResult { get; set; }
        public SolidColorBrush SelectedColor { get; set; }
    }
}