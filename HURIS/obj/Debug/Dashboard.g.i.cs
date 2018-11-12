﻿#pragma checksum "..\..\Dashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "56D62BD63D4032C0FE22006216C93EAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace HURIS {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtEmployees;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDepartment;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Content;
        
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
            System.Uri resourceLocater = new System.Uri("/HURIS;component/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dashboard.xaml"
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
            
            #line 24 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnLogout);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 42 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnDashboard);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 45 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnDashboard);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 51 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnAttendance);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 54 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnAttendance);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 57 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnLeaves);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 60 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnLeaves);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 64 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnEmployees);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtEmployees = ((System.Windows.Controls.TextBlock)(target));
            
            #line 67 "..\..\Dashboard.xaml"
            this.txtEmployees.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnEmployees);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 71 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnDepartment);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtDepartment = ((System.Windows.Controls.TextBlock)(target));
            
            #line 74 "..\..\Dashboard.xaml"
            this.txtDepartment.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnDepartment);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 80 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnPayroll);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 83 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnPayroll);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 87 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnSettings);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 90 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnSettings);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Content = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

