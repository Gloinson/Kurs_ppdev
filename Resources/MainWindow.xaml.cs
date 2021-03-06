﻿using System;
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

namespace Resources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StaticResourceChangeValue_Click(object sender, RoutedEventArgs e)
        {
            var cb = Resources["defaultIrgendwas"];
            if (cb is SolidColorBrush c)
                c.Color = Colors.BlanchedAlmond;
        }

        private void StaticResourceChangeInstance_Click(object sender, RoutedEventArgs e)
        {
            Resources["defaultIrgendwas"] = new SolidColorBrush(Colors.BlueViolet);
        }

        private void NewWindow(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
