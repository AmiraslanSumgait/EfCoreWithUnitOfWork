﻿#pragma checksum "..\..\..\AddWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1C0DF27E8ADE591BF45E77149F0BECCE080C1BEA"
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
using UnitOfWorkWithEfCore;


namespace UnitOfWorkWithEfCore {
    
    
    /// <summary>
    /// AddWindow
    /// </summary>
    public partial class AddWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_category;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_nameCategory;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_okCate;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancelC;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_product;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_nameP;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_price;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_quantity;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_categoryId;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_okProduct;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancelP;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UnitOfWorkWithEfCore;component/addwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid_category = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txb_nameCategory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btn_okCate = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\AddWindow.xaml"
            this.btn_okCate.Click += new System.Windows.RoutedEventHandler(this.btn_okCate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_cancelC = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\AddWindow.xaml"
            this.btn_cancelC.Click += new System.Windows.RoutedEventHandler(this.btn_cancelC_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grid_product = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.txb_nameP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txb_price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txb_quantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txb_categoryId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btn_okProduct = ((System.Windows.Controls.Button)(target));
            
            #line 124 "..\..\..\AddWindow.xaml"
            this.btn_okProduct.Click += new System.Windows.RoutedEventHandler(this.btn_okProduct_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_cancelP = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\..\AddWindow.xaml"
            this.btn_cancelP.Click += new System.Windows.RoutedEventHandler(this.btn_cancelP_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
