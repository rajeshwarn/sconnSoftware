﻿#pragma checksum "..\..\..\Wnd\WndEditScheduleAction.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4870BD5A12D21ADB00DC84A3FC74EF06"
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


namespace sconnRem.Wnd {
    
    
    /// <summary>
    /// WndEditScheduleAction
    /// </summary>
    public partial class WndEditScheduleAction : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Wnd\WndEditScheduleAction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal sconnRem.Wnd.WndEditScheduleAction WndScheduleAction;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Wnd\WndEditScheduleAction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveSchedActionEdit;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Wnd\WndEditScheduleAction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SckPanConfigureAction;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Wnd\WndEditScheduleAction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdScheduleActionSelect;
        
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
            System.Uri resourceLocater = new System.Uri("/sconnRem;component/wnd/wndeditscheduleaction.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Wnd\WndEditScheduleAction.xaml"
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
            this.WndScheduleAction = ((sconnRem.Wnd.WndEditScheduleAction)(target));
            return;
            case 2:
            this.btnSaveSchedActionEdit = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Wnd\WndEditScheduleAction.xaml"
            this.btnSaveSchedActionEdit.Click += new System.Windows.RoutedEventHandler(this.btnSaveSchedActionEdit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SckPanConfigureAction = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.grdScheduleActionSelect = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
