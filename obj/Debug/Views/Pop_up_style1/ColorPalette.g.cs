﻿#pragma checksum "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6D8EF03F39C10A3D80749C2DF75B693B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace WPFColorPicker {
    
    
    /// <summary>
    /// ColorPalette
    /// </summary>
    public partial class ColorPalette : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Container;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid titlePanel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb moveThumb;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderColorChart;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse colorMarker;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brightnessSliderBorder;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider brightnessSlider;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border currentColorBorder;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFColorPicker;component/views/pop_up_style1/colorpalette.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Container = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.titlePanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.moveThumb = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 27 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
            this.moveThumb.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.moveThumb_DragDelta);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 28 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.borderColorChart = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            
            #line 42 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
            ((System.Windows.Controls.Image)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Image_MouseMove);
            
            #line default
            #line hidden
            return;
            case 7:
            this.colorMarker = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 8:
            this.brightnessSliderBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.brightnessSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 10:
            this.currentColorBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 11:
            this.OK = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
            this.OK.Click += new System.Windows.RoutedEventHandler(this.Ok_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\Views\Pop_up_style1\ColorPalette.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

