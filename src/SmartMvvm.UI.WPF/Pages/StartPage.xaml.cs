﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SmartMvvm.ViewModels.Interfaces;

namespace SmartMvvm.UI.WPF.Pages
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            Debug.WriteLine("Parameterless " + GetType().Name + " created.");
            InitializeComponent();
        }

        public StartPage(IPageViewModel viewModel)
        {
            Debug.WriteLine(GetType().Name + " created.");
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
