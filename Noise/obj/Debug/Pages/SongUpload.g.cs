﻿#pragma checksum "..\..\..\Pages\SongUpload.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5C6D99A63B35B688AB7687C53B72A3D515F7F7B8A7670E760944C4AF4F173E15"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Noise.Pages;
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


namespace Noise.Pages {
    
    
    /// <summary>
    /// SongUpload
    /// </summary>
    public partial class SongUpload : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid songUploadPanel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox songTitleBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox songGenreList;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border thumbDropArea;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border musicDropArea;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image melodyIcon;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock melodyTooltip;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label uploadErrorText;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Pages\SongUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uploadButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Noise;component/pages/songupload.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SongUpload.xaml"
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
            this.songUploadPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.songTitleBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.songGenreList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.thumbDropArea = ((System.Windows.Controls.Border)(target));
            
            #line 72 "..\..\..\Pages\SongUpload.xaml"
            this.thumbDropArea.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Upload_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.musicDropArea = ((System.Windows.Controls.Border)(target));
            
            #line 100 "..\..\..\Pages\SongUpload.xaml"
            this.musicDropArea.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UploadMelody_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.melodyIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.melodyTooltip = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.uploadErrorText = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.uploadButton = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\..\Pages\SongUpload.xaml"
            this.uploadButton.Click += new System.Windows.RoutedEventHandler(this.UploadButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

