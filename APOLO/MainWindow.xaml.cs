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
using System.Threading;

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

            Thread update = new Thread(UpdateThread);
            update.IsBackground = true;
            update.Start();
            
           
        }
        
       

        private void ESP095_Checked(object sender, RoutedEventArgs e)
        {
            //RowESP095.Fill = new SolidColorBrush(Colors.LightBlue);
            //ESP181.IsEnabled = true;
            //RowESP181.Fill= new SolidColorBrush(Colors.LightGreen);
            //Update();

        }

        private void ESP095_Unchecked(object sender, RoutedEventArgs e)
        {
            //RowESP095.Fill = new SolidColorBrush(Colors.LightGreen);
            //ESP181.IsEnabled = false;
            //RowESP181.Fill = new SolidColorBrush(Colors.Salmon
            //Update();
        }

        private void INF117_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void INF117_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        public void UpdateThread()
        {
            bool salida = true;

            while (salida)
            {
                this.Dispatcher.Invoke(() =>
                {
                    Update();
                });
                Thread.Sleep(100);
                
            }
        }

        public void Update()
        {
           
           //PRIMER CUATRIMESTRE
            //ESP-095 y ESP-181
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
                ESP181.IsChecked = false;
                RowESP181.Fill = new SolidColorBrush(Colors.Salmon);
            }
            //INF-117
            if(Convert.ToBoolean(INF117.IsChecked))
            {
                RowINF117.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowINF117.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //ING-105
            if(Convert.ToBoolean(ING105.IsChecked))
            {
                RowING105.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowING105.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //MAT-115
            if(Convert.ToBoolean(MAT115.IsChecked))
            {
                RowMAT115.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowMAT115.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //MAT-160
            if (Convert.ToBoolean(MAT160.IsChecked))
            {
                RowMAT160.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowMAT160.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //ORI-112
            if(Convert.ToBoolean(ORI112.IsChecked))
            {
                RowORI112.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowORI112.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //SOC-116
            if(Convert.ToBoolean(SOC116.IsChecked))
            {
                RowSOC116.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowSOC116.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //SOC-180
            if(Convert.ToBoolean(SOC180.IsChecked))
            {
                RowSOC180.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowSOC180.Fill = new SolidColorBrush(Colors.LightGreen);
            }


            //SEGUNDO CUATRIMESTRE
            //ESP-181
            if(Convert.ToBoolean(ESP181.IsChecked))
            {
                RowESP181.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-164, INF-165 y INF-204
            if (Convert.ToBoolean(INF117.IsChecked) && Convert.ToBoolean(MAT115.IsChecked))
            {
                INF164.IsEnabled = true;
                RowINF164.Fill = new SolidColorBrush(Colors.LightGreen);
                INF165.IsEnabled = true;
                RowINF165.Fill = new SolidColorBrush(Colors.LightGreen);
                INF204.IsEnabled = true;
                RowINF204.Fill= new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF164.IsEnabled = false;
                INF164.IsChecked = false;
                RowINF164.Fill = new SolidColorBrush(Colors.Salmon);
                INF165.IsEnabled = false;
                INF165.IsChecked = false;
                RowINF165.Fill = new SolidColorBrush(Colors.Salmon);
                INF204.IsEnabled = false;
                INF204.IsChecked = false;
                RowINF204.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF164.IsChecked))
            {
                RowINF164.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF165.IsChecked))
            {
                RowINF165.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF204.IsChecked))
            {
                RowINF204.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //ING-115
            if(Convert.ToBoolean(ING105.IsChecked))
            {
                ING115.IsEnabled = true;
                RowING115.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                ING115.IsEnabled = false;
                ING115.IsChecked = false;
                RowING115.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(ING115.IsChecked))
            {
                RowING115.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //MAT-170, MAT-190 Y MAT-191
            if(Convert.ToBoolean(MAT160.IsChecked))
            {
                MAT170.IsEnabled = true;
                RowMAT170.Fill = new SolidColorBrush(Colors.LightGreen);
                MAT190.IsEnabled = true;
                RowMAT190.Fill= new SolidColorBrush(Colors.LightGreen);
                MAT191.IsEnabled = true;
                RowMAT191.Fill= new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                MAT170.IsEnabled = false;
                MAT170.IsChecked = false;
                RowMAT170.Fill = new SolidColorBrush(Colors.Salmon);
                MAT190.IsEnabled = false;
                MAT190.IsChecked = false;
                RowMAT190.Fill = new SolidColorBrush(Colors.Salmon);
                MAT191.IsEnabled = false;
                MAT191.IsChecked = false;
                RowMAT191.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(MAT170.IsChecked))
            {
                RowMAT170.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(MAT190.IsChecked))
            {
                RowMAT190.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(MAT191.IsChecked))
            {
                RowMAT191.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //SOC-150
            if(Convert.ToBoolean(SOC150.IsChecked))
            {
                RowSOC150.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowSOC150.Fill = new SolidColorBrush(Colors.LightGreen);
            }


            //TERCER CUATRIMESTRE
            //ESP-189
            if(Convert.ToBoolean(ESP181.IsChecked))
            {
                ESP189.IsEnabled = true;
                RowESP189.Fill= new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                ESP189.IsEnabled = false;
                ESP189.IsChecked = false;
                RowESP189.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(ESP189.IsChecked))
            {
                RowESP189.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-121, INF-167 y INF-168
            if(Convert.ToBoolean(INF164.IsChecked) && Convert.ToBoolean(INF165.IsChecked))
            {
                INF121.IsEnabled=true;
                RowINF121.Fill= new SolidColorBrush(Colors.LightGreen);
                INF167.IsEnabled = true;
                RowINF167.Fill = new SolidColorBrush(Colors.LightGreen);
                INF168.IsEnabled = true;
                RowINF168.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF121.IsEnabled = false;
                INF121.IsChecked = false;
                RowINF121.Fill = new SolidColorBrush(Colors.Salmon);
                INF167.IsEnabled = false;
                INF167.IsChecked = false;
                RowINF167.Fill = new SolidColorBrush(Colors.Salmon);
                INF168.IsEnabled = false;
                INF168.IsChecked = false;
                RowINF168.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF121.IsChecked))
            {
                RowINF121.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF167.IsChecked))
            {
                RowINF167.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF168.IsChecked))
            {
                RowINF168.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //ING-125
            if (Convert.ToBoolean(ING115.IsChecked))
            {
                ING125.IsEnabled = true;
                RowING125.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                ING125.IsEnabled = false;
                ING125.IsChecked = false;
                RowING125.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(ING125.IsChecked))
            {
                RowING125.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //MAT-340
            if (Convert.ToBoolean(MAT170.IsChecked))
            {
                MAT340.IsEnabled = true;
                RowMAT340.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                MAT340.IsEnabled = false;
                MAT340.IsChecked = false;
                RowMAT340.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(MAT340.IsChecked))
            {
                RowMAT340.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //MAT-500 y MAT-501
            if (Convert.ToBoolean(MAT190.IsChecked) && Convert.ToBoolean(MAT191.IsChecked))
            {
                MAT500.IsEnabled = true;
                RowMAT500.Fill = new SolidColorBrush(Colors.LightGreen);
                MAT501.IsEnabled = true;
                RowMAT501.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                MAT500.IsEnabled = false;
                MAT500.IsChecked = false;
                RowMAT500.Fill = new SolidColorBrush(Colors.Salmon);
                MAT501.IsEnabled = false;
                MAT501.IsChecked = false;
                RowMAT501.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(MAT500.IsChecked))
            {
                RowMAT500.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(MAT501.IsChecked))
            {
                RowMAT501.Fill = new SolidColorBrush(Colors.LightBlue);
            }


            //CUARTO CUATRIMESTRE
            //IEL-100 y IEL-105
            if(Convert.ToBoolean(MAT500.IsChecked) && Convert.ToBoolean(MAT501.IsChecked))
            {
                IEL100.IsEnabled = true;
                RowIEL100.Fill= new SolidColorBrush(Colors.LightGreen);
                IEL105.IsEnabled = true;
                RowIEL105.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                IEL100.IsEnabled = false;
                IEL100.IsChecked = false;
                RowIEL100.Fill = new SolidColorBrush(Colors.Salmon);
                IEL105.IsEnabled = false;
                IEL105.IsChecked = false;
                RowIEL105.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(IEL100.IsChecked))
            {
                RowIEL100.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(IEL105.IsChecked))
            {
                RowIEL105.Fill = new SolidColorBrush(Colors.LightBlue);
            }

        }
    }
}
