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
    public partial class PopUp1 : UserControl
    {
        public SolidColorBrush CurrentColor
        {
            get { return (SolidColorBrush)GetValue(CurrentColorProperty); }
            set { SetValue(CurrentColorProperty, value); }
        }

        public static DependencyProperty CurrentColorProperty =
            DependencyProperty.Register("CurrentColor", typeof(SolidColorBrush), typeof(PopUp1), new PropertyMetadata(Brushes.Black));

        public static RoutedUICommand SelectColorCommand = new RoutedUICommand("SelectColorCommand", "SelectColorCommand", typeof(PopUp1));
        private Window colorPaletteWindow;

        public PopUp1()
        {
            DataContext = this;
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(SelectColorCommand, SelectColorCommandExecute));
        }

        private void SelectColorCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            CurrentColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString(e.Parameter.ToString()));
        }

        private static void ShowModal(Window ColorPaletteWindow)
        {
            ColorPaletteWindow.Owner = Application.Current.MainWindow;
            ColorPaletteWindow.ShowDialog();
        }

        void ColorPalettePopUpKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                colorPaletteWindow.Close();
        }

        public RoutedEventHandler button_click;
        public EventHandler PopUp1_Closed;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PopUp1_Closed(sender, e);
            button_click(sender, e);
            
            e.Handled = false;
        }

        
        public RoutedEventHandler moreColors_clicked;
        private void MoreColorsClicked(object sender, RoutedEventArgs e)
        {
            moreColors_clicked(sender, e);
            
            var colorPaletteDialog = new ColorPalette();
            colorPaletteWindow = new Window
                                        {
                                            AllowsTransparency = true,
                                            Content = colorPaletteDialog,
                                            WindowStyle = WindowStyle.None,
                                            ShowInTaskbar = false,
                                            Background = new SolidColorBrush(Colors.Transparent),
                                            Padding = new Thickness(0),
                                            Margin = new Thickness(0),
                                            WindowState = WindowState.Normal,
                                            WindowStartupLocation = WindowStartupLocation.CenterOwner,
                                            SizeToContent = SizeToContent.WidthAndHeight
                                        };
            colorPaletteWindow.DragMove();
            colorPaletteWindow.KeyDown += ColorPalettePopUpKeyDown;
            colorPaletteDialog.DialogResultEvent += ColorPaletteDialogDialogResultEvent;
            colorPaletteDialog.Drag += ColorPaletteDialogDrag;
            ShowModal(colorPaletteWindow);
        }

        void ColorPaletteDialogDrag(object sender, DragDeltaEventArgs e)
        {
            colorPaletteWindow.DragMove();
        }

        
        void ColorPaletteDialogDialogResultEvent(object sender, EventArgs e)
        {
            colorPaletteWindow.Close();
            var dialogEventArgs = (DialogEventArgs)e;
            if (dialogEventArgs.DialogResult == DialogResult.Cancel)
                return;
            CurrentColor = dialogEventArgs.SelectedColor;
            PopUp1_Closed(sender, e);
        }
    }
}
