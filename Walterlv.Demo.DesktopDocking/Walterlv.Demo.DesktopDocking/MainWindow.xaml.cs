﻿using System;
using System.Windows;

namespace Walterlv.Demo.DesktopDocking
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            DesktopAppBar.SetAppBar(this, ABEdge.Right);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AnotherWindow().Show();
        }
    }
}
