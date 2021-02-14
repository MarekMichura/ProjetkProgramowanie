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

namespace ProjektApp.Pages.Admin {
    /// <summary>
    /// Interaction logic for MainAdmin.xaml
    /// </summary>
    public partial class MainAdmin : UserControl {
        static MainWindow Window =>
            Application.Current.MainWindow as MainWindow;

        public MainAdmin() {
            InitializeComponent();

            Window.TopBar.Content = new TopBar();
            Window.LeftPanel.Content = new LeftPanel();
        }
    }
}
