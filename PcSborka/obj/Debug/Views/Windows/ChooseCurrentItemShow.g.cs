﻿#pragma checksum "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F2D2C07522C25124F9C132F961E3611945E006A4A8476883513ED1A82BA34BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PcSborka.Views.Windows;
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


namespace PcSborka.Views.Windows {
    
    
    /// <summary>
    /// ChooseCurrentItemShow
    /// </summary>
    public partial class ChooseCurrentItemShow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackWindow_button;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Find_textBlock;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Find_textBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Sorting_comboBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CurrentItem_listView;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddToChoose_button;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewItem_button;
        
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
            System.Uri resourceLocater = new System.Uri("/PcSborka;component/views/windows/choosecurrentitemshow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
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
            
            #line 8 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
            ((PcSborka.Views.Windows.ChooseCurrentItemShow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackWindow_button = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
            this.BackWindow_button.Click += new System.Windows.RoutedEventHandler(this.BackWindow_button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Find_textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Find_textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
            this.Find_textBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Find_textBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Sorting_comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
            this.Sorting_comboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Sorting_comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CurrentItem_listView = ((System.Windows.Controls.ListView)(target));
            
            #line 31 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
            this.CurrentItem_listView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.CurrentItem_listView_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
            this.CurrentItem_listView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CurrentItem_listView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddToChoose_button = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
            this.AddToChoose_button.Click += new System.Windows.RoutedEventHandler(this.AddToChoose_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddNewItem_button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Views\Windows\ChooseCurrentItemShow.xaml"
            this.AddNewItem_button.Click += new System.Windows.RoutedEventHandler(this.AddNewItem_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

