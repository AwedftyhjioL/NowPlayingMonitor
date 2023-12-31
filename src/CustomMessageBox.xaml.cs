﻿using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace NowPlayingMonitor
{
    /// <summary>
    /// Interaction logic for CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : MetroWindow
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }


        public CustomMessageBox(string info)
        {
            InitializeComponent();
            txtInfo.Text = info;
        }

        public bool Result { get; private set; }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            Result = true;
            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Result = false;
            Close();
        }

        public static bool Show(string info, Window owner)
        {
            string localizedInfo = Strings.ResourceManager.GetString(info) ?? info;
            var messageBox = new CustomMessageBox(localizedInfo);
            messageBox.Owner = owner;
            messageBox.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            messageBox.ShowDialog();
            return messageBox.Result;
        }
    }
}
