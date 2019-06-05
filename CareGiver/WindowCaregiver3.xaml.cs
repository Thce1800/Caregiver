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
    /// Interaction logic for WindowCaregiver3.xaml
    /// </summary>
    public partial class WindowCaregiver3 : Window
    {

        public WindowCaregiver3()
        {
            InitializeComponent();
            FillcomboBoxes();
        }
        Date currentDate;
        DbOperations dBOp;
        private void FillcomboBoxes()
        {
            dBOp = new DbOperations();
            cmbBoxReturn.ItemsSource = null;
            cmbBoxReturn.ItemsSource = dBOp.Dates(1028);
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            dBOp = new DbOperations();
            currentDate = (Date)cmbBoxReturn.SelectedItem;
            int attId = 0;

            if (currentDate != null)
            {
                //Caregiver c = new Caregiver();

                attId = dBOp.UpdateNonAttendance(3001, "Sjukdom"); //c.CurrentId

                if (attId > 0)
                {
                    DateTime date = currentDate.date_id;
                    dBOp.UpdateScheduleSick(1028, date, attId, currentDate.weekday);
                    this.Close();
                    MessageBox.Show($"{dBOp.GetChildById(1028)} är sjukanmäld och beräknas åter {currentDate}");
                }

                else
                {
                    MessageBox.Show("Något gick fel, kontrollera att du valt rätt datum");
                }

            }

            else
            {
                MessageBox.Show("Vänligen välj ett datum för beräknad återkomst");
            }

        }
        private void CmbBoxReturn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            currentDate = (Date)cmbBoxReturn.SelectedItem;

        }
    }
}
