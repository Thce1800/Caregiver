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
using System.Windows.Shapes;

namespace Caregiver1
{
    /// <summary>
    /// Interaction logic for WindowCaregiver2.xaml
    /// </summary>
    public partial class WindowCaregiver2 : Window
    {
        public WindowCaregiver2()
        {
            InitializeComponent();
            UpdateListview();
        }

        private void UpdateListview()
        {
            DbOperations bd = new DbOperations();
            listView.ItemsSource = null;
            //Sätt in barn från databasen
            listView.ItemsSource = bd.GetChildsSchedule(1028);
        }



    }
}
