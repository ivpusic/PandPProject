﻿#pragma checksum "C:\Users\Ivan\Desktop\seminar baze\PandPproject\PandPproject\Views\Login\LoginRegistrationWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9814E375B9CEEFB5C515697ED5FD3407"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PandPproject.LoginUI;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PandPproject.LoginUI {
    
    
    public partial class LoginRegistrationWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.ChildWindow childWindow;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal PandPproject.LoginUI.LoginForm loginForm;
        
        internal PandPproject.LoginUI.RegistrationForm registrationForm;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PandPproject;component/Views/Login/LoginRegistrationWindow.xaml", System.UriKind.Relative));
            this.childWindow = ((System.Windows.Controls.ChildWindow)(this.FindName("childWindow")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.loginForm = ((PandPproject.LoginUI.LoginForm)(this.FindName("loginForm")));
            this.registrationForm = ((PandPproject.LoginUI.RegistrationForm)(this.FindName("registrationForm")));
        }
    }
}

