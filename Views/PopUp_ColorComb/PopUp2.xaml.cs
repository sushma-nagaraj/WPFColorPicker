using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFColorPicker
{
    /// <summary>
    /// Interaction logic for PopUp1.xaml
    /// </summary>
    public partial class PopUp2 : UserControl
    {
        public SolidColorBrush CurrentColor_Comb
        {
            get { return (SolidColorBrush)GetValue(CurrentColorProperty_Comb); }
            set { SetValue(CurrentColorProperty_Comb, value); }
        }

        public static DependencyProperty CurrentColorProperty_Comb =
            DependencyProperty.Register("CurrentColor_Comb", typeof(SolidColorBrush), typeof(PopUp2), new PropertyMetadata(Brushes.Black));

        public static RoutedUICommand SelectColorCommand = new RoutedUICommand("SelectColorCommand", "SelectColorCommand", typeof(PopUp2));
        private Window colorPickerWindow;

        public PopUp2()
        {
            DataContext = this;
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(SelectColorCommand, SelectColorCommandExecute));
        }

        private void SelectColorCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            CurrentColor_Comb = new SolidColorBrush((Color)ColorConverter.ConvertFromString(e.Parameter.ToString()));
        }

        private static void ShowModal(Window ColorPaletteWindow)
        {
            ColorPaletteWindow.Owner = Application.Current.MainWindow;
            ColorPaletteWindow.ShowDialog();
        }

        void ColorPalettePopUpKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                colorPickerWindow.Close();
        }

        public RoutedEventHandler button_click;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button_click(sender, e);
            
            e.Handled = false;
        }

        public RoutedEventHandler moreColors_clicked;
        private void MoreColorsClicked(object sender, RoutedEventArgs e)
        {
            moreColors_clicked(sender, e);

            var colorPickerDialog = new ColorPickerDialog(CurrentColor_Comb.Color);
            colorPickerWindow = new Window
                                        {
                                            AllowsTransparency = false,
                                            Content = colorPickerDialog,
                                            WindowStyle = WindowStyle.None,
                                            ShowInTaskbar = false,
                                            Padding = new Thickness(0),
                                            Margin = new Thickness(0),
                                            WindowState = WindowState.Normal,
                                            WindowStartupLocation = WindowStartupLocation.CenterOwner,
                                            SizeToContent = SizeToContent.WidthAndHeight,
                                            ResizeMode = ResizeMode.NoResize,
                                            Title = "Color Picker Comb",
                                        };
            colorPickerWindow.DragMove();
            colorPickerWindow.KeyDown += ColorPalettePopUpKeyDown;
            colorPickerDialog.DialogResultEvent += ColorPaletteDialogDialogResultEvent;
            //colorPickerDialog.Drag += ColorPaletteDialogDrag;
            ShowModal(colorPickerWindow);
        }

        //void ColorPaletteDialogDrag(object sender, DragDeltaEventArgs e)
        //{
        //    colorPickerWindow.DragMove();
        //}

        void ColorPaletteDialogDialogResultEvent(object sender, EventArgs e)
        {
            colorPickerWindow.Close();
            var dialogEventArgs = (DialogEventArgs)e;
            if (dialogEventArgs.DialogResult == DialogResult.Cancel)
                return;
            CurrentColor_Comb = dialogEventArgs.SelectedColor;
        }
    }
}
