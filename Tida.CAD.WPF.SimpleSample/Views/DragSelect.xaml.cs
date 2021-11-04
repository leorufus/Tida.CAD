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
using Tida.CAD.DrawObjects;

namespace Tida.CAD.WPF.SimpleSample.Views
{
    /// <summary>
    /// Interaction logic for DragSelect.xaml
    /// </summary>
    public partial class DragSelect : Window
    {
        public DragSelect()
        {
            InitializeComponent();
            checkBox.IsChecked = cadControl.DragSelectEnabled;

            var cadLayer = new CADLayer();
            cadControl.Layers = new CADLayer[] { cadLayer };
            var line = new Line(new Point(0, 0), new Point(10, 10));
            line.Pen = new Pen { Thickness = 2, Brush = Brushes.White };
            cadLayer.AddDrawObject(line);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cadControl.DragSelectEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            cadControl.DragSelectEnabled = false;
        }
    }
}
