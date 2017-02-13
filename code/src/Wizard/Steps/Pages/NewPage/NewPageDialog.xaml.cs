﻿using Microsoft.Templates.Wizard.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Microsoft.Templates.Wizard.Steps.Pages.NewPage
{
    /// <summary>
    /// Interaction logic for PagesTemplatesDialog.xaml
    /// </summary>
    public partial class NewPageDialog : Window
    {
        public NewPageViewModel ViewModel { get; }

        public GenInfo Result { get; set; }

        public NewPageDialog(WizardContext context, IEnumerable<string> selectedNames)
        {
            ViewModel = new NewPageViewModel(context, this, selectedNames);

            DataContext = ViewModel;
            Loaded += PagesTemplatesDialog_Loaded;
            InitializeComponent();
        }

        private async void PagesTemplatesDialog_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.InitializeAsync();
        }
    }
}