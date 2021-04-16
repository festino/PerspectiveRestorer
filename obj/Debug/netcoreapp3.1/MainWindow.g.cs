﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340DB4E64E66C81626546F625C843C0085B8B62F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PerspectiveRestorer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PerspectiveRestorer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel paramPanel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imagePath;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock scaleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox planeCheckBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox axesCheckBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox zCheckBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock miniLog;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image scopedImage;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel resultPanel;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minecraftCommand;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PerspectiveRestorer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\MainWindow.xaml"
            ((PerspectiveRestorer.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\MainWindow.xaml"
            ((PerspectiveRestorer.MainWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\MainWindow.xaml"
            ((PerspectiveRestorer.MainWindow)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.paramPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.imagePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 52 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenImageButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.scaleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.planeCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.planeCheckBox.Click += new System.Windows.RoutedEventHandler(this.canvasCheckBox_Changed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.axesCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.axesCheckBox.Click += new System.Windows.RoutedEventHandler(this.canvasCheckBox_Changed);
            
            #line default
            #line hidden
            return;
            case 8:
            this.zCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.zCheckBox.Click += new System.Windows.RoutedEventHandler(this.canvasCheckBox_Changed);
            
            #line default
            #line hidden
            return;
            case 9:
            this.miniLog = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.scopedImage = ((System.Windows.Controls.Image)(target));
            
            #line 62 "..\..\..\MainWindow.xaml"
            this.scopedImage.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.scopedImage_MouseWheel);
            
            #line default
            #line hidden
            
            #line 62 "..\..\..\MainWindow.xaml"
            this.scopedImage.MouseMove += new System.Windows.Input.MouseEventHandler(this.scopedImage_MouseMove);
            
            #line default
            #line hidden
            
            #line 63 "..\..\..\MainWindow.xaml"
            this.scopedImage.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.scopedImage_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 63 "..\..\..\MainWindow.xaml"
            this.scopedImage.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.scopedImage_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 63 "..\..\..\MainWindow.xaml"
            this.scopedImage.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.scopedImage_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 66 "..\..\..\MainWindow.xaml"
            this.canvas.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.scopedImage_MouseWheel);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\MainWindow.xaml"
            this.canvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.scopedImage_MouseMove);
            
            #line default
            #line hidden
            
            #line 67 "..\..\..\MainWindow.xaml"
            this.canvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.scopedImage_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 67 "..\..\..\MainWindow.xaml"
            this.canvas.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.scopedImage_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 67 "..\..\..\MainWindow.xaml"
            this.canvas.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.scopedImage_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.resultPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 13:
            this.minecraftCommand = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

