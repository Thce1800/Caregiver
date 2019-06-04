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

namespace CareGiver
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
        WindowCargiver1 window1;
        Schedule currentDate;
        private void UpdateListview()
        {
            DbOperations db = new DbOperations();
            lblChild.Content = db.GetChildById(1028);
            listView.ItemsSource = null;
            listView.ItemsSource = db.GetChildsSchedule(1028);
        }
        private void ShowWindow3()
        {
            WindowCaregiver3 window3 = new WindowCaregiver3();
            window3.Show();

        }
        private void ShowWindow1()
        {
            window1 = new WindowCargiver1();
            window1.Show();
            this.Close();
        }
        private void CloseWindow1()
        {
            window1 = new WindowCargiver1();
            window1.Close();

        }
        private void ShowMainwindow()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
        private void BtnSickReport_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow3();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1();
        }
        private void BtnSignOut_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow1();
            ShowMainwindow();
        }
    }
}
