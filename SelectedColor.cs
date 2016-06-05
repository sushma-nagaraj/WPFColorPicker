using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFColorPicker
{
    public class SelectedColor: INotifyPropertyChanged
    {
        private SolidColorBrush currentSelectedColor;

        public SolidColorBrush CurrentSelectedColor
        {
            get { return currentSelectedColor; }
            set 
            {
                if (currentSelectedColor != null)
                {
                    lock (currentSelectedColor)
                    {
                        if (value != currentSelectedColor)
                        {
                            currentSelectedColor = value;
                            NotifyPropertyChanged();
                        }
                    }
                }
                else
                {
                    currentSelectedColor = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
    }
}
