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

namespace Binding_RelSourcePreviousData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            items.ItemsSource = GetData();
        }

        private IReadOnlyCollection<Item> GetData()
        {
            var rnd = new Random();
            var ret = new List<Item>();
            for (int i = 0; i < 50; i++)
            {
                ret.Add(new Item { Value = rnd.Next(100) });
            }
            return ret;
        }

        private IReadOnlyCollection<Item> MyItemData
        {
            get
            {
                var rnd = new Random();
                var ret = new List<Item>();
                for (int i = 0; i < 50; i++)
                {
                    ret.Add(new Item { Value = rnd.Next(100) });
                }
                return ret;
            }
        }
    }
}
