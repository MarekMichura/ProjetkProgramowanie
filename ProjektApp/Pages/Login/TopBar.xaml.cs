﻿using ProjektApp.Pages.Buttons;
using System.Windows.Controls;

namespace ProjektApp.Pages.Login {
    /// <summary>
    /// Interaction logic for TopBar.xaml
    /// </summary>
    public partial class TopBar : UserControl {
        /// <summary>
        /// Menu nawigacyjne dla widoku logowania
        /// </summary>
        public TopBar() {
            InitializeComponent();
            Exit.Content = new Exit();
        }
    }
}
