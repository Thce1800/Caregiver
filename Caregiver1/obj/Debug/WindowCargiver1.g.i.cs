﻿#pragma checksum "..\..\WindowCargiver1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63B27FBAC84C1EF15A834690E93CADEB6AECBB15"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caregiver1;
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


namespace Caregiver1 {
    
    
    /// <summary>
    /// WindowCargiver1
    /// </summary>
    public partial class WindowCargiver1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\WindowCargiver1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstBoxCaregiver;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\WindowCargiver1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCaregiver;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\WindowCargiver1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindowCargiver1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLogin;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WindowCargiver1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblChildren;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowCargiver1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSchedule;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WindowCargiver1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBoxChildren;
        
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
            System.Uri resourceLocater = new System.Uri("/Caregiver1;component/windowcargiver1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowCargiver1.xaml"
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
            this.lstBoxCaregiver = ((System.Windows.Controls.ListBox)(target));
            
            #line 10 "..\..\WindowCargiver1.xaml"
            this.lstBoxCaregiver.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LstBoxCaregiver_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblCaregiver = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\WindowCargiver1.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.BtnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblLogin = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblChildren = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnSchedule = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\WindowCargiver1.xaml"
            this.btnSchedule.Click += new System.Windows.RoutedEventHandler(this.BtnChild_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbBoxChildren = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
