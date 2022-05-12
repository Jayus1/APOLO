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
            //MED-750
            if(Convert.ToBoolean(MED750.IsChecked))
            {
                RowMED750.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowMED750.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //MED-755
            if(Convert.ToBoolean(MED755.IsChecked))
            {
                RowMED755.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowMED755.Fill = new SolidColorBrush(Colors.LightGreen);
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
            //INF-171, INF-172, INF-173, INF-385 Y INF-387
            if (Convert.ToBoolean(INF121.IsChecked)&&Convert.ToBoolean(INF167.IsChecked)&&Convert.ToBoolean(INF168.IsChecked))
            {
                INF171.IsEnabled=true;
                RowINF171.Fill= new SolidColorBrush(Colors.LightGreen);
                INF172.IsEnabled=true;
                RowINF172.Fill= new SolidColorBrush(Colors.LightGreen);
                INF173.IsEnabled = true;
                RowINF173.Fill = new SolidColorBrush(Colors.LightGreen);
                INF385.IsEnabled = true;
                RowINF385.Fill = new SolidColorBrush(Colors.LightGreen);
                INF387.IsEnabled = true;
                RowINF387.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF171.IsEnabled = false;
                INF171.IsChecked = false;
                RowINF171.Fill = new SolidColorBrush(Colors.Salmon);
                INF172.IsEnabled = false;
                INF172.IsChecked = false;
                RowINF172.Fill = new SolidColorBrush(Colors.Salmon);
                INF173.IsEnabled = false;
                INF173.IsChecked = false;
                RowINF173.Fill = new SolidColorBrush(Colors.Salmon);
                INF385.IsEnabled = false;
                INF385.IsChecked = false;
                RowINF385.Fill = new SolidColorBrush(Colors.Salmon);
                INF387.IsEnabled = false;
                INF387.IsChecked = false;
                RowINF387.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF171.IsChecked))
            {
                RowINF171.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF172.IsChecked))
            {
                RowINF172.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF173.IsChecked))
            {
                RowINF173.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF385.IsChecked))
            {
                RowINF385.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF387.IsChecked))
            {
                RowINF387.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //ING-165
            if (Convert.ToBoolean(ING125.IsChecked))
            {
                ING165.IsEnabled = true;
                RowING165.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                ING165.IsEnabled = false;
                ING165.IsChecked = false;
                RowING165.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(ING165.IsChecked))
            {
                RowING165.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //MAT-350
            if (Convert.ToBoolean(MAT340.IsChecked))
            {
                MAT350.IsEnabled = true;
                RowMAT350.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                MAT350.IsEnabled = false;
                MAT350.IsChecked = false;
                RowMAT350.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(MAT350.IsChecked))
            {
                RowMAT350.Fill = new SolidColorBrush(Colors.LightBlue);
            }

            //QUINTO CUATRIMESTRE
            //DIB-520
            if (Convert.ToBoolean(DIB520.IsChecked))
            {
                RowDIB520.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowDIB520.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //IID-420
            if (Convert.ToBoolean(IID420.IsChecked))
            {
                RowIID420.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowIID420.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //INF-440 y INF-445
            if (Convert.ToBoolean(IEL100.IsChecked) && Convert.ToBoolean(IEL105.IsChecked) && Convert.ToBoolean(INF204.IsChecked))
            {
                INF440.IsEnabled = true;
                RowINF440.Fill = new SolidColorBrush(Colors.LightGreen);
                INF445.IsEnabled = true;
                RowINF445.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF440.IsEnabled = false;
                INF440.IsChecked = false;
                RowINF440.Fill = new SolidColorBrush(Colors.Salmon);
                INF445.IsEnabled = false;
                INF445.IsChecked = false;
                RowINF445.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF440.IsChecked))
            {
                RowINF440.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF445.IsChecked))
            {
                RowINF445.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-481, INF-482 y INF-535
            if (Convert.ToBoolean(INF171.IsChecked) && Convert.ToBoolean(INF385.IsChecked) && Convert.ToBoolean(INF387.IsChecked))
            {
                INF481.IsEnabled=true;
                RowINF481.Fill = new SolidColorBrush(Colors.LightGreen);
                INF482.IsEnabled=true;
                RowINF482.Fill= new SolidColorBrush(Colors.LightGreen);
                INF535.IsEnabled=true;
                RowINF535.Fill= new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF481.IsEnabled = false;
                INF481.IsChecked=false;
                RowINF481.Fill = new SolidColorBrush(Colors.Salmon);
                INF482.IsEnabled = false;
                INF482.IsChecked = false;
                RowINF482.Fill = new SolidColorBrush(Colors.Salmon);
                INF535.IsEnabled = false;
                INF535.IsChecked = false;
                RowINF535.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF481.IsChecked))
            {
                RowINF481.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF482.IsChecked))
            {
                RowINF482.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF535.IsChecked))
            {
                RowINF535.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //MAT-360
            if (Convert.ToBoolean(MAT350.IsChecked))
            {
                MAT360.IsEnabled = true;
                RowMAT360.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                MAT360.IsEnabled = false;
                MAT360.IsChecked = false;
                RowMAT360.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(MAT360.IsChecked))
            {
                RowMAT360.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //SOC-700
            if (Convert.ToBoolean(SOC700.IsChecked))
            {
                RowSOC700.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowSOC700.Fill = new SolidColorBrush(Colors.LightGreen);
            }

            //SEXTO CUATRIMESTRE
            //INF-184 Y INF-185
            if (Convert.ToBoolean(INF440.IsChecked)&& Convert.ToBoolean(INF445.IsChecked))
            {
                INF184.IsEnabled = true;
                RowINF184.Fill= new SolidColorBrush(Colors.LightGreen);
                INF185.IsEnabled = true;
                RowINF185.Fill= new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF184.IsEnabled = false;
                INF184.IsChecked = false;
                RowINF184.Fill = new SolidColorBrush(Colors.Salmon);
                INF185.IsEnabled = false;
                INF185.IsChecked = false;
                RowINF185.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF184.IsChecked))
            {
                RowINF184.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF185.IsChecked))
            {
                RowINF185.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            //INF-213 Y INF-214
            if (Convert.ToBoolean(INF172.IsChecked) && Convert.ToBoolean(INF173.IsChecked))
            {
                INF213.IsEnabled = true;
                RowINF213.Fill= new SolidColorBrush(Colors.LightGreen);
                INF214.IsEnabled = true;
                RowINF214.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF213.IsEnabled = false;
                INF213.IsChecked = false;
                RowINF213.Fill = new SolidColorBrush(Colors.Salmon);
                INF214.IsEnabled = false;
                INF214.IsChecked = false;
                RowINF214.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF213.IsChecked))
            {
                RowINF213.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF214.IsChecked))
            {
                RowINF214.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-225 y INF-331
            if(Convert.ToBoolean(ESP095.IsChecked) && Convert.ToBoolean(INF117.IsChecked) && Convert.ToBoolean(ING105.IsChecked) && Convert.ToBoolean(MAT115.IsChecked) && Convert.ToBoolean(MAT160.IsChecked) && Convert.ToBoolean(ORI112.IsChecked) && Convert.ToBoolean(SOC116.IsChecked) && Convert.ToBoolean(SOC180.IsChecked))
            {
                if (Convert.ToBoolean(ESP181.IsChecked) && Convert.ToBoolean(INF164.IsChecked) && Convert.ToBoolean(INF165.IsChecked) && Convert.ToBoolean(INF204.IsChecked) && Convert.ToBoolean(ING115.IsChecked) && Convert.ToBoolean(MAT170.IsChecked) && Convert.ToBoolean(MAT190.IsChecked) && Convert.ToBoolean(MAT191.IsChecked) && Convert.ToBoolean(SOC150.IsChecked))
                {
                    if (Convert.ToBoolean(ESP189.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF167.IsChecked) && Convert.ToBoolean(INF168.IsChecked) && Convert.ToBoolean(ING125.IsChecked) && Convert.ToBoolean(MAT340.IsChecked) && Convert.ToBoolean(MAT500.IsChecked) && Convert.ToBoolean(MAT501.IsChecked) && Convert.ToBoolean(MED750.IsChecked) && Convert.ToBoolean(MED755.IsChecked) &&)
                    {
                        if (Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF121.IsChecked))
                        {
                            if()
                            {

                            }
                        }
                    }
                }
            }
            else
            {
                INF225.IsEnabled=false;
                RowINF225.Fill = new SolidColorBrush(Colors.Salmon);
                INF331.IsEnabled = false;
                RowINF331.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF225.IsChecked))
            {
                RowINF225.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            if(Convert.ToBoolean(INF331.IsChecked))
            {
                RowINF331.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //SOC-140
            if (Convert.ToBoolean(SOC140.IsChecked))
            {
                RowSOC140.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowSOC140.Fill = new SolidColorBrush(Colors.LightGreen);
            }
        }
    }
}
