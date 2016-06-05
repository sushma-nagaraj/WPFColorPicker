using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using System.ComponentModel;


namespace WPFColorPicker
{
    /// <summary>
    /// Interaction logic for ColorPickerView1.xaml
    /// </summary>
    public partial class ColorPickerView1 : UserControl
    {
        SelectedColor currentColor = new SelectedColor();

        public SelectedColor CurrentColor
        {
            get { return currentColor; }
            set { currentColor = value; }
        }
        
        public ColorPickerView1()
        {
            InitializeComponent();
            
            colorPalette.button_click += new RoutedEventHandler(Button_Click);
            colorPalette.moreColors_clicked += new RoutedEventHandler(MoreColorsClicked);
            currentColor.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Color_Changed);
            colorPalette.PopUp1_Closed += new EventHandler(popup_Closed);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.popup.IsOpen = false;
        }
        private void MoreColorsClicked(object sender, RoutedEventArgs e)
        {
            this.popup.IsOpen = false;
        }

        public EventHandler ColorPicker_Closed;
        private void popup_Closed(object sender, EventArgs e)
        {
            Button p = sender as Button;
            if (p != null)
            {
                currentColor.CurrentSelectedColor = (SolidColorBrush) p.Background;
                ColorPicker_Closed(sender, e);
            }
        }

        public EventHandler color_Changed;
        void Color_Changed(object sender, PropertyChangedEventArgs e)
        {
            color_Changed(sender, e);
        }
    }
}
