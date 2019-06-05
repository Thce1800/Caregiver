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
    /// Interaction logic for WindowCargiver1.xaml
    /// </summary>
    public partial class WindowCargiver1 : Window
    {
        public WindowCargiver1()
        {
            InitializeComponent();
            FillListBoxCaregiver();
        }
        DbOperations dbOperations;
        Caregiver currentCg;
        private void FillListBoxCaregiver()
        {

            dbOperations = new DbOperations();
            List<Caregiver> caregivers = dbOperations.GetAllCaregivers();
            lstBoxCaregiver.ItemsSource = null;
            lstBoxCaregiver.ItemsSource = caregivers;

        }
        private void ShowWindow2()
        {
            WindowCaregiver2 windowCaregiver2 = new WindowCaregiver2();
            windowCaregiver2.Show();
            this.Close();
        }
        private void FillListComboBoxChildren()
        {

            dbOperations = new DbOperations();
            List<Child> children = dbOperations.GetChildren(4020);
            cmbBoxChildren.ItemsSource = null;
            cmbBoxChildren.ItemsSource = children;

        }
        private void LstBoxCaregiver_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentCg = (Caregiver)lstBoxCaregiver.SelectedItem;
            //currentCg.CurrentId = currentCg.Id;
            if (currentCg != null)
            {
                lblLogin.Content = currentCg;
            }
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (currentCg != null)
            {
                FillListComboBoxChildren();
                btnLogin.IsEnabled = false;
            }

            else
            {
                MessageBox.Show("Du måste välja ditt namn i listan för att kunna logga in");
               
            }

            lblChildren.Content = "Välj barn";
            

        }
        private void BtnChild_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow2();
        }
        private void CmbBoxChildren_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Child currentChild = (Child)cmbBoxChildren.SelectedItem;
            if (currentChild != null)
            {
                currentChild.CurrentID = currentChild.Id;
                btnSchedule.IsEnabled = true;
            }

        }
    }
}
