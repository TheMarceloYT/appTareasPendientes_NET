﻿#pragma checksum "..\..\..\views\AdministrarCategorias.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "98654B82DBCC47DC78C6B749AE90256CAF3FE3761AD8128FEF04C90F42C02A38"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentacion.views;
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


namespace Presentacion.views {
    
    
    /// <summary>
    /// AdministrarCategorias
    /// </summary>
    public partial class AdministrarCategorias : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\..\views\AdministrarCategorias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitulo;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\views\AdministrarCategorias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNuevaCat;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\views\AdministrarCategorias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNombre;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\views\AdministrarCategorias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreCategoria;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\views\AdministrarCategorias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNuevaCategoria;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\views\AdministrarCategorias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCategoriasListado;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\views\AdministrarCategorias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstCategorias;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\views\AdministrarCategorias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarCategoria;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/views/administrarcategorias.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\views\AdministrarCategorias.xaml"
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
            
            #line 11 "..\..\..\views\AdministrarCategorias.xaml"
            ((Presentacion.views.AdministrarCategorias)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblTitulo = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblNuevaCat = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblNombre = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtNombreCategoria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnNuevaCategoria = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\views\AdministrarCategorias.xaml"
            this.btnNuevaCategoria.Click += new System.Windows.RoutedEventHandler(this.btnNuevaCategoria_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblCategoriasListado = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lstCategorias = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.btnEliminarCategoria = ((System.Windows.Controls.Button)(target));
            
            #line 193 "..\..\..\views\AdministrarCategorias.xaml"
            this.btnEliminarCategoria.Click += new System.Windows.RoutedEventHandler(this.btnEliminarCategoria_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
