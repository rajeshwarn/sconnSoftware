﻿#pragma checksum "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "59AF39AABA31464A8CC4C217B77D56C1"
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
using sconnRem.View.Config;
using sconnRem.ViewModel.Alarm;


namespace sconnRem.View.Config {
    
    
    /// <summary>
    /// ConfigSelect
    /// </summary>
    public partial class ConfigSelect : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// StckConfigSelect Name Field
        /// </summary>
        
        #line 15 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.StackPanel StckConfigSelect;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image00;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image01;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image02;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image10;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image11;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image12;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image20;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image21;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image22;
        
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
            System.Uri resourceLocater = new System.Uri("/sconnRem.Controls.AlarmSystem;component/view/config/alarmsystem/configselectview" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
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
            this.StckConfigSelect = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.Image00 = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            
            #line 54 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Settings);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Image01 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.Image02 = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            
            #line 65 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Settings);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Image10 = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            
            #line 70 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Settings);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Image11 = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            
            #line 75 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Settings);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Image12 = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            
            #line 82 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Settings);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Image20 = ((System.Windows.Controls.Image)(target));
            return;
            case 14:
            
            #line 87 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Settings);
            
            #line default
            #line hidden
            return;
            case 15:
            this.Image21 = ((System.Windows.Controls.Image)(target));
            return;
            case 16:
            
            #line 92 "..\..\..\..\..\View\Config\AlarmSystem\ConfigSelectView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Settings);
            
            #line default
            #line hidden
            return;
            case 17:
            this.Image22 = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

