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
            FillListBoxChildren();
        }
        DbOperations dbOp;
        Child currentChild;

        private void FillListBoxChildren()
        {

            dbOp = new DbOperations();
            List<Child> children = dbOp.GetChildren();
            lstBoxChild.ItemsSource = null;
            lstBoxChild.ItemsSource = children;

        }
        private void ShowWindow3()
        {
            WindowCaregiver3 windowCaregiver3 = new WindowCaregiver3();
            windowCaregiver3.Show();
            this.Close();
        }
        private void LstBoxChild_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentChild = (Child)lstBoxChild.SelectedItem;
            if (currentChild != null)
            {
                lblChild.Content = currentChild;
            }
        }
        private void BtnSchedule_Click(object sender, RoutedEventArgs e)
        {
            if (currentChild != null)
            {
                ShowWindow3();
            }

            else
            {
                MessageBox.Show("Du måste välja ett barn för att kunna gå vidare till schemat");
            }
        }
    }
}
