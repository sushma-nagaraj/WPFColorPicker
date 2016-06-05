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
using System.Windows.Shapes;

namespace WPFColorPicker
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        private List<SolidColorBrush> recentlyUsedColors;

        private bool backgroundColorActive = false;
        private SolidColorBrush currentBackground = new SolidColorBrush();
        private SolidColorBrush currentForeground = new SolidColorBrush();

        public ColorPicker()
        {
            InitializeComponent();
            recentlyUsedColors = loadRecentlyUsedColors();
            btnViewMore.ColorPicker_Closed += new EventHandler(btnViewMore_Unloaded);
        }

        private void btnColor_MouseRightButtonUp(object sender, RoutedEventArgs e)
        {
            Button btnColor = sender as Button;
            Rectangle recColor = (Rectangle)btnColor.Content;
            Rectangle recBackground = (Rectangle)btnBackground.Content;
            recBackground.Fill = recColor.Fill;
        }

        private void btnColor_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            Button btnColor = sender as Button;
            Rectangle recColor = (Rectangle)btnColor.Content;
            Rectangle recForeground = (Rectangle)btnForeground.Content;
            recForeground.Fill = recColor.Fill;
        }

        private List<SolidColorBrush> loadRecentlyUsedColors()
        {
            List<SolidColorBrush> ruc = new List<SolidColorBrush>();


            return ruc;
        }

        private void btnViewMore_Unloaded(object sender, EventArgs e)
        {
            //Button btnViewMore = sender as Button;
            
            currentBackground = btnViewMore.CurrentColor.CurrentSelectedColor;
            Rectangle recColor = (Rectangle)btnColor1.Content;
            Rectangle recBackground = (Rectangle)btnBackground.Content;
            Rectangle recForeground = (Rectangle)btnForeground.Content;

            recColor.Fill = currentBackground;

            if(backgroundColorActive)
            {
                recBackground.Fill = currentBackground;
            }
            else
            {
                recForeground.Fill = currentBackground;
            }
        }

        private void btnViewmore1_Unloaded(object sender, RoutedEventArgs e)
        {
            ColorPickerView2 o_ColorPickerView2 = sender as ColorPickerView2;
            currentBackground = o_ColorPickerView2.CurrentColor;
            Rectangle recColor = (Rectangle)btnColor7.Content;
            Rectangle recBackground = (Rectangle)btnBackground.Content;

            recColor.Fill = currentBackground;
            recBackground.Fill = currentBackground;
        }

        private void btnBackground_Checked(object sender, RoutedEventArgs e)
        {
            backgroundColorActive = true;
        }

        private void btnForeground_Checked(object sender, RoutedEventArgs e)
        {
            backgroundColorActive = false;
        }
    }
}
