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


            //void Update()
            //{
            //    if (Convert.ToBoolean(ESP095.IsChecked))
            //    {
            //        RowESP095.Fill = new SolidColorBrush(Colors.LightBlue);
            //        ESP181.IsEnabled = true;
            //        RowESP181.Fill = new SolidColorBrush(Colors.LightGreen);
            //    }
            //    else
            //    {
            //        RowESP095.Fill = new SolidColorBrush(Colors.LightGreen);
            //        ESP181.IsEnabled = false;
            //        RowESP181.Fill = new SolidColorBrush(Colors.Salmon);
            //    }
            //}
        }
        //List<Materia> Materias = new List<Materia>();
        //Materia ESP095 = new Materia("ESP095", true);
        //Materia INF117 = new Materia("INF117", true);
        //Materia ING105 = new Materia("ING105", true);
        //Materia MAT115 = new Materia("MAT115", true);
        //Materia MAT160 = new Materia("MAT160", true);
        //Materia ORI112 = new Materia("ORI112", true);
        //Materia SOC115 = new Materia("SOC115", true);
        //Materia SOC180 = new Materia("SOC180", true);
        //Materias.AddRange(new []= { ESP095, INF117 });
       

        private void ESP095_Checked(object sender, RoutedEventArgs e)
        {
            //RowESP095.Fill = new SolidColorBrush(Colors.LightBlue);
            //ESP181.IsEnabled = true;
            //RowESP181.Fill= new SolidColorBrush(Colors.LightGreen);
            Update();

        }

        private void ESP095_Unchecked(object sender, RoutedEventArgs e)
        {
            //RowESP095.Fill = new SolidColorBrush(Colors.LightGreen);
            //ESP181.IsEnabled = false;
            //RowESP181.Fill = new SolidColorBrush(Colors.Salmon
            Update();
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

        public void Update()
        {
            if (Convert.ToBoolean(ESP095.IsChecked))
            {
                RowESP095.Fill = new SolidColorBrush(Colors.LightBlue);
                ESP181.IsEnabled = true;
                RowESP181.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                RowESP095.Fill = new SolidColorBrush(Colors.LightGreen);
                ESP181.IsEnabled = false;
                RowESP181.Fill = new SolidColorBrush(Colors.Salmon);
            }

            if (Convert.ToBoolean(INF117.IsChecked) && Convert.ToBoolean(MAT115.IsChecked))
            {
                INF164.IsEnabled = true;
                RowINF164.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            if (!(Convert.ToBoolean(INF117.IsChecked) && Convert.ToBoolean(MAT115.IsChecked)))
            {
                INF164.IsEnabled = false;
                RowINF164.Fill = new SolidColorBrush(Colors.Salmon);
            }
        }
    }
}
