﻿#pragma checksum "..\..\Menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4FB0F4E4AFF3819C5D709CFE929586D9CB1848D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Test;
using WpfAnimatedGif;


namespace Test {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label6;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label7;
        
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
            System.Uri resourceLocater = new System.Uri("/Test;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu.xaml"
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
            this.text = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\Menu.xaml"
            this.text.MouseEnter += new System.Windows.Input.MouseEventHandler(this.text_MouseMove);
            
            #line default
            #line hidden
            
            #line 22 "..\..\Menu.xaml"
            this.text.MouseLeave += new System.Windows.Input.MouseEventHandler(this.text_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label1 = ((System.Windows.Controls.Label)(target));
            
            #line 53 "..\..\Menu.xaml"
            this.label1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label1_MouseMove);
            
            #line default
            #line hidden
            
            #line 54 "..\..\Menu.xaml"
            this.label1.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label1_MouseLeave);
            
            #line default
            #line hidden
            
            #line 55 "..\..\Menu.xaml"
            this.label1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Label1_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label2 = ((System.Windows.Controls.Label)(target));
            
            #line 66 "..\..\Menu.xaml"
            this.label2.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.label2_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 67 "..\..\Menu.xaml"
            this.label2.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label2_MouseMove);
            
            #line default
            #line hidden
            
            #line 68 "..\..\Menu.xaml"
            this.label2.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label2_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label3 = ((System.Windows.Controls.Label)(target));
            
            #line 78 "..\..\Menu.xaml"
            this.label3.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.label3_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 79 "..\..\Menu.xaml"
            this.label3.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label3_MouseMove);
            
            #line default
            #line hidden
            
            #line 80 "..\..\Menu.xaml"
            this.label3.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label3_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label6 = ((System.Windows.Controls.Label)(target));
            
            #line 103 "..\..\Menu.xaml"
            this.label6.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label6_MouseMove);
            
            #line default
            #line hidden
            
            #line 104 "..\..\Menu.xaml"
            this.label6.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label6_MouseLeave);
            
            #line default
            #line hidden
            
            #line 105 "..\..\Menu.xaml"
            this.label6.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.label6_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label7 = ((System.Windows.Controls.Label)(target));
            
            #line 114 "..\..\Menu.xaml"
            this.label7.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label7_MouseMove);
            
            #line default
            #line hidden
            
            #line 115 "..\..\Menu.xaml"
            this.label7.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label7_MouseLeave);
            
            #line default
            #line hidden
            
            #line 116 "..\..\Menu.xaml"
            this.label7.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.label7_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 126 "..\..\Menu.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown_one);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 127 "..\..\Menu.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
