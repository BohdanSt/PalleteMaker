﻿using Microsoft.Win32;
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
using PaletteMaker.Palette;
using Emgu.CV;
using Emgu.CV.Structure;
using MahApps.Metro.Controls;

namespace PaletteMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuControl_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.menuControl.Content = e.ClickedItem;
            this.menuControl.IsPaneOpen = false;
        }
    }
}
