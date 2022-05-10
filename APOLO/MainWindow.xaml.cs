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
using System.Runtime.CompilerServices;

namespace APOLO
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

        public class Materia
        {
            //public Materia (string seccion, bool status)
            //{
            //    Seccion = seccion;
            //    Status = status;
            //}
            public String Seccion { get; set; }
            public bool Status { get; set; }

            public List Requisitos;
        }

        Materia P = new Materia();
        

        private void ESP095_Checked(object sender, RoutedEventArgs e)
        {
            RowESP095.Fill = new SolidColorBrush(Colors.LightBlue);
            ESP181.IsEnabled = true;
            RowESP181.Fill= new SolidColorBrush(Colors.LightGreen);
            //  P.Status = (bool)ESP095.IsChecked;
            MessageBox.Show(Convert.ToString(P.Status));
        }

        private void ESP095_Unchecked(object sender, RoutedEventArgs e)
        {
            RowESP095.Fill = new SolidColorBrush(Colors.LightGreen);
            ESP181.IsEnabled = false;
            RowESP181.Fill = new SolidColorBrush(Colors.Salmon);
        }

        private void INF117_Checked(object sender, RoutedEventArgs e)
        {
            RowINF117.Fill= new SolidColorBrush(Colors.LightBlue);

            if(INF164.IsChecked==true)
            {

            }
        }

        private void INF117_Unchecked(object sender, RoutedEventArgs e)
        {
            RowINF117.Fill = new SolidColorBrush(Colors.LightGreen);
        }
    }
    

}
