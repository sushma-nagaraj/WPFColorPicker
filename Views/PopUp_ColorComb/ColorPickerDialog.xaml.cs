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
using System.Windows.Ink;

namespace WPFColorPicker
{
    /// <summary>
    /// Interaction logic for ColorPickerDialog.xaml
    /// </summary>
    public partial class ColorPickerDialog : UserControl
    {
        private Color oldColor, newColor;
        public SolidColorBrush CurrentColor = new SolidColorBrush();
        public event EventHandler DialogResultEvent;

        //
        // Initialization

        public ColorPickerDialog(Color oldColor)
        {
            this.oldColor = oldColor;
            newColor = oldColor;
            InitializeComponent();
        }

        
        // Completes initialization after all XAML member vars have been initialized.
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            UpdateControlValues();
            UpdateControlVisuals();

            colorComb.ColorSelected += new EventHandler<ColorEventArgs>(colorComb_ColorSelected);
            brightnessSlider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(brightnessSlider_ValueChanged);
            opacitySlider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(opacitySlider_ValueChanged);

            acceptButton.Click += new RoutedEventHandler(acceptButton_Click);
            cancelButton.Click += new RoutedEventHandler(cancelButton_Click);

            rectangle2.Fill = new System.Windows.Media.SolidColorBrush(oldColor);
        }

        //
        // Implementation

        bool _notUserInitiated;

        // Updates values of controls when new DA is set (or upon initialization).
        void UpdateControlValues()
        {
            _notUserInitiated = true;
            try
            {
                // Set nominal color on comb.
                //Color nc = m_selectedDA.Color;
                Color nc = newColor;
                float f = Math.Max(Math.Max(nc.ScR, nc.ScG), nc.ScB);
                if (f < 0.001f) // black
                    nc = Color.FromScRgb(1f, 1f, 1f, 1f);
                else
                    nc = Color.FromScRgb(1f, nc.ScR / f, nc.ScG / f, nc.ScB / f);
                colorComb.SelectedColor = nc;

                // Set brightness and opacity.
                brightnessSlider.Value = f;
                opacitySlider.Value = newColor.ScA;

            }
            finally
            {
                _notUserInitiated = false;
            }
        }

        // Updates visual properties of all controls, in response to any change.
        void UpdateControlVisuals()
        {
            Color c = newColor;

            // Update LGB for brightnessSlider
            Border sb1 = brightnessSlider.Parent as Border;
            LinearGradientBrush lgb1 = sb1.Background as LinearGradientBrush;
            lgb1.GradientStops[1].Color = colorComb.SelectedColor;

            // Update LGB for opacitySlider
            Color c2a = Color.FromScRgb(0f, c.ScR, c.ScG, c.ScB);
            Color c2b = Color.FromScRgb(1f, c.ScR, c.ScG, c.ScB);
            Border sb2 = opacitySlider.Parent as Border;
            LinearGradientBrush lgb2 = sb2.Background as LinearGradientBrush;
            lgb2.GradientStops[0].Color = c2a;
            lgb2.GradientStops[1].Color = c2b;

            rectangle1.Fill = new System.Windows.Media.SolidColorBrush(c);
        }

        //
        // Event Handlers

        void colorComb_ColorSelected(object sender, ColorEventArgs e)
        {
            if (_notUserInitiated) return;

            float a, f, r, g, b;
            a = (float)opacitySlider.Value;
            f = (float)brightnessSlider.Value;

            Color nc = e.Color;
            r = f * nc.ScR;
            g = f * nc.ScG;
            b = f * nc.ScB;

            newColor = Color.FromScRgb(a, r, g, b);
            UpdateControlVisuals();
        }

        void brightnessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_notUserInitiated) return;

            Color nc = colorComb.SelectedColor;
            float f = (float)e.NewValue;

            float a, r, g, b;
            a = (float)opacitySlider.Value;
            r = f * nc.ScR;
            g = f * nc.ScG;
            b = f * nc.ScB;

            newColor = Color.FromScRgb(a, r, g, b);
            UpdateControlVisuals();
        }

        void opacitySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_notUserInitiated) return;

            Color c = newColor;
            float a = (float)e.NewValue;

            newColor = Color.FromScRgb(a, c.ScR, c.ScG, c.ScB);
            UpdateControlVisuals();
        }

        private void OnDialogResultEvent(DialogEventArgs e)
        {
            var dialogResultEvent = DialogResultEvent;
            if (dialogResultEvent != null)
                dialogResultEvent(this, e);
        }

        void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            // Setting this property closes the dialog, when shown modally.
            //this.DialogResult = true;
            OnDialogResultEvent(new DialogEventArgs() { SelectedColor = new SolidColorBrush(this.newColor), DialogResult = DialogResult.Ok });
        }

        void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Setting this property closes the dialog, when shown modally.
            //this.DialogResult = false;
            OnDialogResultEvent(new DialogEventArgs() { SelectedColor = new SolidColorBrush(this.oldColor), DialogResult = DialogResult.Ok });
        }
    }
}
