﻿using System.Windows;

namespace TreeViewSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new NodeFactory().GetNodes();
        }
    }
}
