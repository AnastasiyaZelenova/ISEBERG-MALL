﻿#pragma checksum "..\..\GuestPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "40FF1B3892605A1F6619BFFF71BBA367"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ICEBERG_MALL;
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


namespace ICEBERG_MALL {
    
    
    /// <summary>
    /// GuestPage
    /// </summary>
    public partial class GuestPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\GuestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCategory;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\GuestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxTradePoint;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\GuestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewCategory;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\GuestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewTradePoint;
        
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
            System.Uri resourceLocater = new System.Uri("/ICEBERG-MALL;component/guestpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GuestPage.xaml"
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
            this.textBoxCategory = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\GuestPage.xaml"
            this.textBoxCategory.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxCategory_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxTradePoint = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\GuestPage.xaml"
            this.textBoxTradePoint.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxTradePoint_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listViewCategory = ((System.Windows.Controls.ListView)(target));
            
            #line 36 "..\..\GuestPage.xaml"
            this.listViewCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listViewTradePoint = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

