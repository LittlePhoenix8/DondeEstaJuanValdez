﻿#pragma checksum "C:\Users\Jaime Acevedo\documents\visual studio 2012\Projects\JuanValdez\JuanValdez\Local.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "28E45F2E2690DCBC786F18F43C39365E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18051
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace JuanValdez {
    
    
    public partial class Local : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock JuanValdez;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.StackPanel ContentPane;
        
        internal System.Windows.Controls.ScrollViewer mainScrollViewer;
        
        internal System.Windows.Controls.StackPanel panelCentral;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/JuanValdez;component/Local.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.JuanValdez = ((System.Windows.Controls.TextBlock)(this.FindName("JuanValdez")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPane = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPane")));
            this.mainScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("mainScrollViewer")));
            this.panelCentral = ((System.Windows.Controls.StackPanel)(this.FindName("panelCentral")));
        }
    }
}

