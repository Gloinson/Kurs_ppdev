﻿using HelloMVVM.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloMVVM.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // V1: set DataContext explizitly
            // DataContext = new MainWindowViewModel();
        }

        // V2: direct implementation is baaaad
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    (DataContext as MainWindowViewModel).WelcomeText = "You're not welcome anymore!";
        //}
    }
}
