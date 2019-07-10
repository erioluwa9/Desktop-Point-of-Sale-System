﻿#pragma checksum "..\..\..\Views\AddCustomer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "164248EB723B2EFF205CACD6758ABEFEF4771EDDA6C2B33F912987A30E6BF8E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Point_of_Sale_System;
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


namespace Point_of_Sale_System {
    
    
    /// <summary>
    /// AddCustomer
    /// </summary>
    public partial class AddCustomer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TopBarCustomer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button powerButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phoneNumber;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CustomerSave;
        
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
            System.Uri resourceLocater = new System.Uri("/Point of Sale System;component/views/addcustomer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddCustomer.xaml"
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
            this.TopBarCustomer = ((System.Windows.Controls.Grid)(target));
            
            #line 16 "..\..\..\Views\AddCustomer.xaml"
            this.TopBarCustomer.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TopBarCustomer_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.powerButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\AddCustomer.xaml"
            this.powerButton.Click += new System.Windows.RoutedEventHandler(this.PowerButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.customerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.phoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CustomerSave = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Views\AddCustomer.xaml"
            this.CustomerSave.Click += new System.Windows.RoutedEventHandler(this.CustomerSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
