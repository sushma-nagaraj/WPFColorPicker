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


namespace WPFColorPicker
{
    /// <summary>
    /// Interaction logic for ColorPickerView1.xaml
    /// </summary>
    public partial class ColorPickerView2 : UserControl
    {
        public SolidColorBrush CurrentColor = new SolidColorBrush();

        public ColorPickerView2()
        {
            InitializeComponent();

            colorComb.button_click += new RoutedEventHandler(Button_Click);
            colorComb.moreColors_clicked += new RoutedEventHandler(MoreColorsClicked);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.popup.IsOpen = false;
        }
        private void MoreColorsClicked(object sender, RoutedEventArgs e)
        {
            this.popup.IsOpen = false;
        }

        private void popup_Closed(object sender, EventArgs e)
        {            
            PopUp2 p = sender as PopUp2;
            if(p != null)
                CurrentColor = p.CurrentColor_Comb;            
        }
    }
}
