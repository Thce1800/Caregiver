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
using Npgsql;

namespace CareGiver
{
    /// <summary>
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
            UpdateListview();
        }

        private void UpdateListview()
        {
            DbOperations bd = new DbOperations();
            lblChildName.Content = bd.GetChildById(1028);
            listView.ItemsSource = null;
            try
            {
                listView.ItemsSource = bd.GetChildsSchedule(1028);
            }
            catch (PostgresException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        
        private void CloseWindowAdd()
        {
            WindowCaregiver2 win2 = new WindowCaregiver2();
            win2.Show();
            this.Close();
        }
        public int GetNewNumber()
        {
            int newId = 0;
            DbOperations ob = new DbOperations();

            newId = ob.ScheduleID();

            return newId + 1;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool breakfast = false; bool meal = false; bool attendance = false;
            int ID = GetNewNumber();
            //NÄR BLIR ATTENDANCE FALSE? SJUKANMÄLAN MÅSTE GÖRA ALLT FALSE? LEDIG BLIR SAMMA SOM sjukanmälan fast inte id-sjukdom?
            //TROR ATT JAG HÄMTAR DATUM SOM dd-MM-yyyy??? NEJ DU HÄMTAR DET SOM MM-dd-yyyy

            DateTime date = Convert.ToDateTime(tbxDate.Text);
            DateTime timeStart = Convert.ToDateTime(tbxTimeIn.Text);
            DateTime timeEnd = Convert.ToDateTime(tbxTimeEnd.Text);
            string weekday = date.ToString("dddd");
            lblWeekday.Content = weekday;
            DateTime t1 = Convert.ToDateTime("08:30");
            DbOperations ab = new DbOperations();

            try
            {
                if (timeStart > t1)
                {
                    attendance = true;
                    breakfast = false;
                    meal = false;

                }
                else if (timeStart < t1)
                {
                    attendance = true;
                    breakfast = true;
                    meal = true;
                }
                else
                {
                    MessageBox.Show("något blev fel");
                }
                //GÅR DET ATT FÅ DIT BARNET (id 1028) AUTOMATISKT?
                ab.AddSchedule(ID, date, weekday, breakfast, meal, timeStart, timeEnd, attendance, 1028);
                UpdateListview();
            }
            catch (PostgresException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLedig_Click(object sender, RoutedEventArgs e)
        {
            DateTime offDate = Convert.ToDateTime(tbxLedig.Text);
            DbOperations ob = new DbOperations();
            //GÅR DET ATT FÅ DIT BARNET (id 1028) AUTOMATISKT?
            ob.DeleteSchedule(offDate, 1028);
            UpdateListview();
        }

        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            CloseWindowAdd();
        }
    }
}

