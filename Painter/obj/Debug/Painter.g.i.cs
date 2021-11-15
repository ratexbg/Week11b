﻿#pragma checksum "..\..\Painter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEFD43079235ADBA4E4A9E56B0FD1B178BF158AE71A3228BBD3E44B67E4E50F6"
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


namespace Painter {
    
    
    /// <summary>
    /// PainterWindow
    /// </summary>
    public partial class PainterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas paintCanvas;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton redRadioButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton blueRadioButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton greenRadioButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton blackRadioButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton smallRadioButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton mediumRadioButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton largeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button undoButton;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Painter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Painter;component/painter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Painter.xaml"
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
            this.paintCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 18 "..\..\Painter.xaml"
            this.paintCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.paintCanvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 19 "..\..\Painter.xaml"
            this.paintCanvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.paintCanvas_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 20 "..\..\Painter.xaml"
            this.paintCanvas.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.paintCanvas_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 21 "..\..\Painter.xaml"
            this.paintCanvas.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.paintCanvas_MouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\Painter.xaml"
            this.paintCanvas.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.paintCanvas_MouseRightButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.redRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 34 "..\..\Painter.xaml"
            this.redRadioButton.Checked += new System.Windows.RoutedEventHandler(this.redRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.blueRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 36 "..\..\Painter.xaml"
            this.blueRadioButton.Checked += new System.Windows.RoutedEventHandler(this.blueRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.greenRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 38 "..\..\Painter.xaml"
            this.greenRadioButton.Checked += new System.Windows.RoutedEventHandler(this.greenRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.blackRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 40 "..\..\Painter.xaml"
            this.blackRadioButton.Checked += new System.Windows.RoutedEventHandler(this.blackRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.smallRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 49 "..\..\Painter.xaml"
            this.smallRadioButton.Checked += new System.Windows.RoutedEventHandler(this.smallRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mediumRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 51 "..\..\Painter.xaml"
            this.mediumRadioButton.Checked += new System.Windows.RoutedEventHandler(this.mediumRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.largeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 54 "..\..\Painter.xaml"
            this.largeRadioButton.Checked += new System.Windows.RoutedEventHandler(this.largeRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.undoButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\Painter.xaml"
            this.undoButton.Click += new System.Windows.RoutedEventHandler(this.undoButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.clearButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\Painter.xaml"
            this.clearButton.Click += new System.Windows.RoutedEventHandler(this.clearButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

