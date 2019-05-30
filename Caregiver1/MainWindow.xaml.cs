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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Caregiver1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void ShowLoginWindowCaregiver()
        {
            WindowCargiver1 windowCaregiver1 = new WindowCargiver1();
            windowCaregiver1.Show();
            this.Close();
        }

        private void ShowWindowPersonel1()
        {
            WindowPersonel1 windowPersonel1 = new WindowPersonel1();
            windowPersonel1.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowLoginWindowCaregiver();
        }

        private void BtnPersonel_Click(object sender, RoutedEventArgs e)
        {
            ShowWindowPersonel1();
        }
    }
}
