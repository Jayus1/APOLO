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
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace APOLO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            Exist(Path);
            Thread update = new Thread(UpdateThread);
            update.IsBackground = true;
            update.Start();
        }

        private string available; //="18";
        private string noAvailable; // = "72";
        private string take; // = "0";
        public string Path { get => @"C:\Windows\Temp\ApoloData.json"; }

        public string Available { get => available; set { available = value; OnPropertyChanged("Available"); }  }
        public string NoAvailable { get => noAvailable; set { noAvailable = value; OnPropertyChanged("NoAvailable"); } }
        public string Take { get => take; set { take = value; OnPropertyChanged("Take"); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string property)  //[CallerMemberName] string property=null)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

 #region 'Contadores'
        public void Count()
        {
            Available = "0";
            NoAvailable = "0";
            Take = "0";

            //PRIMER CUATRIMESTRE
            //ESP-095
            if (Convert.ToString(RowESP095.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowESP095.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowESP095.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-117
            if (Convert.ToString(RowINF117.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF117.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF117.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //ING-105
            if (Convert.ToString(RowING105.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowING105.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowING105.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-115
            if (Convert.ToString(RowMAT115.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT115.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT115.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-160
            if (Convert.ToString(RowMAT160.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT160.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT160.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //ORI-112
            if (Convert.ToString(RowORI112.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowORI112.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowORI112.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //SOC-116
            if (Convert.ToString(RowSOC116.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowSOC116.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowSOC116.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //SOC-180
            if (Convert.ToString(RowSOC180.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowSOC180.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowSOC180.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //SEGUNDO CUATRIMESTRE
            //ESP-181
            if (Convert.ToString(RowESP181.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowESP181.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowESP181.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-164
            if (Convert.ToString(RowINF164.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF164.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF164.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-165
            if (Convert.ToString(RowINF165.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF165.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF165.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-204
            if (Convert.ToString(RowINF204.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF204.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF204.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //ING-115
            if (Convert.ToString(RowING115.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowING115.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowING115.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-170
            if (Convert.ToString(RowMAT170.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT170.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT170.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-190
            if (Convert.ToString(RowMAT190.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT190.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT190.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-191
            if (Convert.ToString(RowMAT191.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT191.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT191.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //SOC-150
            if (Convert.ToString(RowSOC150.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowSOC150.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowSOC150.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //TERCER CUATRIMESTRE
            //ESP-189
            if (Convert.ToString(RowESP189.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowESP189.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowESP189.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-121
            if (Convert.ToString(RowINF121.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF121.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF121.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-167
            if (Convert.ToString(RowINF167.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF167.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF167.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-168
            if (Convert.ToString(RowINF168.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF168.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF168.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //ING-125
            if (Convert.ToString(RowING125.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowING125.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowING125.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-340
            if (Convert.ToString(RowMAT340.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT340.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT340.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-500
            if (Convert.ToString(RowMAT500.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT500.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT500.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-501
            if (Convert.ToString(RowMAT501.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT501.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT501.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MED-750
            if (Convert.ToString(RowMED750.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMED750.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMED750.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MED-755
            if (Convert.ToString(RowMED755.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMED755.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMED755.Fill) == "#FFFA8072")
            {
                RedUp();
            }



            //CUARTO CUATRIMESTRE
            //IEL-100
            if (Convert.ToString(RowIEL100.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIEL100.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIEL100.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //IEL-105
            if (Convert.ToString(RowIEL105.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIEL105.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIEL105.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-171
            if (Convert.ToString(RowINF171.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF171.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF171.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-172
            if (Convert.ToString(RowINF172.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF172.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF172.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-173
            if (Convert.ToString(RowINF173.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF173.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF173.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-385
            if (Convert.ToString(RowINF385.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF385.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF385.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-387
            if (Convert.ToString(RowINF387.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF387.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF387.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //ING-165
            if (Convert.ToString(RowING165.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowING165.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowING165.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-350
            if (Convert.ToString(RowMAT350.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT350.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT350.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //QUINTO CUATRIMESTRE
            //DIB-520
            if (Convert.ToString(RowDIB520.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowDIB520.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowDIB520.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //IID-420
            if (Convert.ToString(RowIID420.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIID420.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIID420.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-440
            if (Convert.ToString(RowINF440.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF440.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF440.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-445
            if (Convert.ToString(RowINF445.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF445.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF445.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-481
            if (Convert.ToString(RowINF481.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF481.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF481.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-482
            if (Convert.ToString(RowINF482.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF482.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF482.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-535
            if (Convert.ToString(RowINF535.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF535.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF535.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-360
            if (Convert.ToString(RowMAT360.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT360.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT360.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //SOC-700
            if (Convert.ToString(RowSOC700.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowSOC700.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowSOC700.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //SEXTO CUATRIMESTRE
            //INF-184
            if (Convert.ToString(RowINF184.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF184.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF184.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-185
            if (Convert.ToString(RowINF185.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF185.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF185.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-213
            if (Convert.ToString(RowINF213.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF213.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF213.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-214
            if (Convert.ToString(RowINF214.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF214.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF214.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-225
            if (Convert.ToString(RowINF225.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF225.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF225.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-331
            if (Convert.ToString(RowINF331.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF331.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF331.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-135
            if (Convert.ToString(RowMAT135.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT135.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT135.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //SOC-140
            if (Convert.ToString(RowSOC140.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowSOC140.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowSOC140.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //SEPTIMO CUATRIMESTRE
            //ESP-301
            if (Convert.ToString(RowESP301.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowESP301.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowESP301.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-502
            if (Convert.ToString(RowINF502.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF502.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF502.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-503
            if (Convert.ToString(RowINF503.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF503.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF503.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-700
            if (Convert.ToString(RowINF700.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF700.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF700.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-705
            if (Convert.ToString(RowINF705.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF705.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF705.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-706
            if (Convert.ToString(RowINF706.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF706.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF706.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //MAT-145
            if (Convert.ToString(RowMAT145.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowMAT145.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowMAT145.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //SOC-170
            if (Convert.ToString(RowSOC170.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowSOC170.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowSOC170.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //OCTAVO CUATRIMESTRE
            //IID-725	
            if (Convert.ToString(RowIID725.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIID725.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIID725.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-241
            if (Convert.ToString(RowINF241.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF241.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF241.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-810
            if (Convert.ToString(RowINF810.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF810.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF810.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-840
            if (Convert.ToString(RowINF840.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF840.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF840.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //NOVENO CUATRIMESTRE
            //ADM-910
            if (Convert.ToString(RowADM910.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowADM910.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowADM910.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //IID-830
            if (Convert.ToString(RowIID830.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIID830.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIID830.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-021
            if (Convert.ToString(RowINF021.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF021.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF021.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-411
            if (Convert.ToString(RowINF411.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF411.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF411.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-412
            if (Convert.ToString(RowINF412.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF412.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF412.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-450
            if (Convert.ToString(RowINF450.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF450.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF450.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-910
            if (Convert.ToString(RowINF910.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF910.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF910.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //DECIMO CUATRIMESTRE
            //ADM-900
            if (Convert.ToString(RowADM900.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowADM900.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowADM900.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //IID-945
            if (Convert.ToString(RowIID945.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIID945.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIID945.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-344
            if (Convert.ToString(RowINF344.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF344.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF344.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-345
            if (Convert.ToString(RowINF345.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF345.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF345.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-433
            if (Convert.ToString(RowINF433.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF433.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF433.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-920
            if (Convert.ToString(RowINF920.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF920.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF920.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //DECIMO PRIMER CUATRIMESTRE
            //DPG-010
            if (Convert.ToString(RowDPG010.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowDPG010.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowDPG010.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //IID-025
            if (Convert.ToString(RowIID025.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIID025.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIID025.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-025
            if (Convert.ToString(RowINF025.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF025.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF025.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-820
            if (Convert.ToString(RowINF820.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF820.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF820.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //SOC-160
            if (Convert.ToString(RowSOC160.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowSOC160.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowSOC160.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //DECIMO SEGUNDO CUATRIMESTRE
            //INF-008
            if (Convert.ToString(RowINF008.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF008.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF008.Fill) == "#FFFA8072")
            {
                RedUp();
            }

            //MATERIA ELECTIVA
            //IEL-200
            if (Convert.ToString(RowIEL200.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIEL200.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIEL200.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //IEL-205
            if (Convert.ToString(RowIEL205.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowIEL205.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowIEL205.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-022
            if (Convert.ToString(RowINF022.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF022.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF022.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-023
            if (Convert.ToString(RowINF023.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF023.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF023.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-024
            if (Convert.ToString(RowINF024.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF024.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF024.Fill) == "#FFFA8072")
            {
                RedUp();
            }
            //INF-026
            if (Convert.ToString(RowINF026.Fill) == "#FF90EE90")
            {
                GreenUp();
            }
            else if (Convert.ToString(RowINF026.Fill) == "#FFADD8E6")
            {
                BlueUp();
            }
            else if (Convert.ToString(RowINF026.Fill) == "#FFFA8072")
            {
                RedUp();
            }


        }
        public void GreenUp()
        {
            int pass = Convert.ToInt32(Available);
            Available = Convert.ToString(pass + 1);
        }
        public void RedUp()
        {
            int pass = Convert.ToInt32(NoAvailable);
            NoAvailable = Convert.ToString(pass + 1);
        }
        public void BlueUp()
        {
            int pass = Convert.ToInt32(Take);
            Take = Convert.ToString(pass + 1);
        }
#endregion 


        public void UpdateThread()
        {
            bool salida = true;

            try
            {
                while (salida)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        Update();
                        Count();

                    });
                    Thread.Sleep(100);

                }
            }
            catch (Exception ex)
            {
                Thread.Sleep(0);
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
            if(Convert.ToBoolean(ESP095.IsChecked) && Convert.ToBoolean(INF117.IsChecked) && Convert.ToBoolean(ING105.IsChecked) && Convert.ToBoolean(MAT115.IsChecked) && Convert.ToBoolean(MAT160.IsChecked) && Convert.ToBoolean(ORI112.IsChecked) && Convert.ToBoolean(SOC116.IsChecked) && Convert.ToBoolean(SOC180.IsChecked) && Convert.ToBoolean(ESP181.IsChecked) && Convert.ToBoolean(INF164.IsChecked) && Convert.ToBoolean(INF165.IsChecked) && Convert.ToBoolean(INF204.IsChecked) && Convert.ToBoolean(ING115.IsChecked) && Convert.ToBoolean(MAT170.IsChecked) && Convert.ToBoolean(MAT190.IsChecked) && Convert.ToBoolean(MAT191.IsChecked) && Convert.ToBoolean(SOC150.IsChecked) && Convert.ToBoolean(ESP189.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF167.IsChecked) && Convert.ToBoolean(INF168.IsChecked) && Convert.ToBoolean(ING125.IsChecked) && Convert.ToBoolean(MAT340.IsChecked) && Convert.ToBoolean(MAT500.IsChecked) && Convert.ToBoolean(MAT501.IsChecked) && Convert.ToBoolean(MED750.IsChecked) && Convert.ToBoolean(MED755.IsChecked) && Convert.ToBoolean(IEL100.IsChecked) && Convert.ToBoolean(IEL105.IsChecked) && Convert.ToBoolean(INF171.IsChecked) && Convert.ToBoolean(INF172.IsChecked) && Convert.ToBoolean(INF173.IsChecked) && Convert.ToBoolean(INF385.IsChecked) && Convert.ToBoolean(INF387.IsChecked) && Convert.ToBoolean(ING165.IsChecked) && Convert.ToBoolean(MAT350.IsChecked) && Convert.ToBoolean(DIB520.IsChecked) && Convert.ToBoolean(IID420.IsChecked) && Convert.ToBoolean(INF440.IsChecked) && Convert.ToBoolean(INF445.IsChecked) && Convert.ToBoolean(INF481.IsChecked) && Convert.ToBoolean(INF482.IsChecked) && Convert.ToBoolean(INF535.IsChecked) && Convert.ToBoolean(MAT360.IsChecked) && Convert.ToBoolean(SOC700.IsChecked))
            {                           
                INF225.IsEnabled = true;
                RowINF225.Fill = new SolidColorBrush(Colors.LightGreen);
                INF331.IsEnabled = true;
                RowINF331.Fill = new SolidColorBrush(Colors.LightGreen);                                                                     
            }           
            else
            {
                INF225.IsEnabled = false;
                INF225.IsChecked = false;
                RowINF225.Fill = new SolidColorBrush(Colors.Salmon);
                INF331.IsEnabled = false;
                INF331.IsChecked = false;
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
            //MAT-135
            if (Convert.ToBoolean(MAT340.IsChecked))
            {
                MAT135.IsEnabled = true;
                RowMAT135.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                MAT135.IsEnabled = false;
                MAT135.IsChecked = false;
                RowMAT135.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(MAT135.IsChecked))
            {
                RowMAT135.Fill = new SolidColorBrush(Colors.LightBlue);
            }


            //SEPTIMO CUATRIMESTRE
            //ESP-301
            if(Convert.ToBoolean(ESP189.IsChecked))
            {
                ESP301.IsEnabled= true;
                RowESP301.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                ESP301.IsEnabled = false;
                ESP301.IsChecked = false;
                RowESP301.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(ESP301.IsChecked))
            {
                RowESP301.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-502 Y INF-503
            if (Convert.ToBoolean(INF213.IsChecked) && Convert.ToBoolean(INF214.IsChecked))
            {
                INF502.IsEnabled= true;
                RowINF502.Fill = new SolidColorBrush(Colors.LightGreen);
                INF503.IsEnabled = true;
                RowINF503.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF502.IsEnabled = false;
                INF502.IsChecked = false;
                RowINF502.Fill = new SolidColorBrush(Colors.Salmon);
                INF503.IsEnabled = false;
                INF503.IsChecked = false;
                RowINF503.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF502.IsChecked))
            {
                RowINF502.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            if(Convert.ToBoolean(INF503.IsChecked))
            {
                RowINF503.Fill= new SolidColorBrush(Colors.LightBlue);
            }
            //INF-700
            if(Convert.ToBoolean(INF184.IsChecked) && Convert.ToBoolean(INF185.IsChecked) && Convert.ToBoolean(INF440.IsChecked) && Convert.ToBoolean(INF445.IsChecked))
            {
                INF700.IsEnabled = true;
                RowINF700.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF700.IsEnabled = false;
                RowINF700.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF700.IsChecked))
            {
                RowINF700.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-705 Y INF-706
            if (Convert.ToBoolean(MAT360.IsChecked))
            {
                INF705.IsEnabled = true;
                RowINF705.Fill = new SolidColorBrush(Colors.LightGreen);
                INF706.IsEnabled = true;
                RowINF706.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF705.IsEnabled = false;
                INF705.IsChecked = false;
                RowINF705.Fill = new SolidColorBrush(Colors.Salmon);
                INF706.IsEnabled = false;
                INF705.IsChecked = false;
                RowINF706.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF705.IsChecked))
            {
                RowINF705.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if(Convert.ToBoolean(INF706.IsChecked))
            {
                RowINF706.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //MAT-145
            if (Convert.ToBoolean(MAT135.IsChecked))
            {
                MAT145.IsEnabled = true;
                RowMAT145.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                MAT145.IsEnabled = false;
                MAT145.IsChecked = false;
                RowMAT145.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(MAT145.IsChecked))
            {
                RowMAT145.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //SOC-170
            if (Convert.ToBoolean(SOC170.IsChecked))
            {
                RowSOC170.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowSOC170.Fill = new SolidColorBrush(Colors.LightGreen);
            }

            //OCTAVO CUATRIMESTRE
            //IID-725
            if(Convert.ToBoolean(MAT360.IsChecked))
            {
                IID725.IsEnabled = true;
                RowIID725.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                IID725.IsEnabled = false;
                IID725.IsChecked = false;
                RowIID725.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(IID725.IsChecked))
            {
                RowIID725.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-241 Y INF-810
            if (Convert.ToBoolean(INF225.IsChecked))
            {
                INF241.IsEnabled = true;
                RowINF241.Fill = new SolidColorBrush(Colors.LightGreen);
                INF810.IsEnabled = true;
                RowINF810.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF241.IsEnabled = false;
                INF241.IsChecked = false;
                RowINF241.Fill = new SolidColorBrush(Colors.Salmon);
                INF810.IsEnabled = false;
                INF810.IsChecked = false;
                RowINF810.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF241.IsChecked))
            {
                RowINF241.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF810.IsChecked))
            {
                RowINF810.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-840
            if (Convert.ToBoolean(INF535.IsChecked) && Convert.ToBoolean(INF700.IsChecked))
            {
                INF840.IsEnabled = true;
                RowINF840.Fill=new SolidColorBrush(Colors.LightGreen);

            }
            else
            {
                INF840.IsEnabled = false;
                INF840.IsChecked = false;
                RowINF840.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF840.IsChecked))
            {
                RowINF840.Fill= new SolidColorBrush(Colors.LightBlue);
            }


            //NOVENO CUATRIMESTRE
            //ADM-910
            if (Convert.ToBoolean(ADM910.IsChecked))
            {
                RowADM910.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowADM910.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            //IID-830
            if (Convert.ToBoolean(IID725.IsChecked))
            {
                IID830.IsEnabled = true;
                RowIID830.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                IID830.IsEnabled = false;
                IID830.IsChecked = false;
                RowIID830.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(IID830.IsChecked))
            {
                RowIID830.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-021 Y INF-450
            if(Convert.ToBoolean(INF241.IsChecked))
            {
                INF021.IsEnabled = true;
                RowINF021.Fill = new SolidColorBrush(Colors.LightGreen);
                INF450.IsEnabled=true;
                RowINF450.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF021.IsEnabled = false;
                INF021.IsChecked = false;
                RowINF021.Fill = new SolidColorBrush(Colors.Salmon);
                INF450.IsEnabled = false;
                INF450.IsChecked = false;
                RowINF450.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF021.IsChecked))
            {
                RowINF021.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if(Convert.ToBoolean(INF450.IsChecked))
            {
                RowINF450.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-411 Y INF-412
            if(Convert.ToBoolean(INF184.IsChecked) && Convert.ToBoolean(INF185.IsChecked) && Convert.ToBoolean(INF440.IsChecked) && Convert.ToBoolean(INF445.IsChecked))
            {
                INF411.IsEnabled=true;
                RowINF411.Fill = new SolidColorBrush(Colors.LightGreen);
                INF412.IsEnabled=true;
                RowINF412.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF411.IsEnabled = false;
                INF411.IsChecked = false;
                RowINF411.Fill = new SolidColorBrush(Colors.Salmon);
                INF412.IsEnabled = false;
                INF412.IsChecked = false;
                RowINF412.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF411.IsChecked))
            {
                RowINF411.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF412.IsChecked))
            {
                RowINF412.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-910
            if (Convert.ToBoolean(INF700.IsChecked))
            {
                INF910.IsEnabled = true;
                RowINF910.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF910.IsEnabled = false;
                INF910.IsChecked = false;
                RowINF910.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF910.IsChecked))
            {
                RowINF910.Fill = new SolidColorBrush(Colors.LightBlue);
            }

            //DECIMO CUATRIMESTRE
            //ADM-900
            if (Convert.ToBoolean(ESP095.IsChecked) && Convert.ToBoolean(INF117.IsChecked) && Convert.ToBoolean(ING105.IsChecked) && Convert.ToBoolean(MAT115.IsChecked) && Convert.ToBoolean(MAT160.IsChecked) && Convert.ToBoolean(ORI112.IsChecked) && Convert.ToBoolean(SOC116.IsChecked) && Convert.ToBoolean(SOC180.IsChecked) && 
                Convert.ToBoolean(ESP181.IsChecked) && Convert.ToBoolean(INF164.IsChecked) && Convert.ToBoolean(INF165.IsChecked) && Convert.ToBoolean(INF204.IsChecked) && Convert.ToBoolean(ING115.IsChecked) && Convert.ToBoolean(MAT170.IsChecked) && Convert.ToBoolean(MAT190.IsChecked) && Convert.ToBoolean(MAT191.IsChecked) && Convert.ToBoolean(SOC150.IsChecked) && 
                Convert.ToBoolean(ESP189.IsChecked) && Convert.ToBoolean(INF121.IsChecked) && Convert.ToBoolean(INF167.IsChecked) && Convert.ToBoolean(INF168.IsChecked) && Convert.ToBoolean(ING125.IsChecked) && Convert.ToBoolean(MAT340.IsChecked) && Convert.ToBoolean(MAT500.IsChecked) && Convert.ToBoolean(MAT501.IsChecked) && Convert.ToBoolean(MED750.IsChecked) && Convert.ToBoolean(MED755.IsChecked) && 
                Convert.ToBoolean(IEL100.IsChecked) && Convert.ToBoolean(IEL105.IsChecked) && Convert.ToBoolean(INF171.IsChecked) && Convert.ToBoolean(INF172.IsChecked) && Convert.ToBoolean(INF173.IsChecked) && Convert.ToBoolean(INF385.IsChecked) && Convert.ToBoolean(INF387.IsChecked) && Convert.ToBoolean(ING165.IsChecked) && Convert.ToBoolean(MAT350.IsChecked) && 
                Convert.ToBoolean(DIB520.IsChecked) && Convert.ToBoolean(IID420.IsChecked) && Convert.ToBoolean(INF440.IsChecked) && Convert.ToBoolean(INF445.IsChecked) && Convert.ToBoolean(INF481.IsChecked) && Convert.ToBoolean(INF482.IsChecked) && Convert.ToBoolean(INF535.IsChecked) && Convert.ToBoolean(MAT360.IsChecked) && Convert.ToBoolean(SOC700.IsChecked) &&
                Convert.ToBoolean(INF184.IsChecked) && Convert.ToBoolean(INF185.IsChecked) && Convert.ToBoolean(INF213.IsChecked) && Convert.ToBoolean(INF214.IsChecked) && Convert.ToBoolean(INF225.IsChecked) && Convert.ToBoolean(INF331.IsChecked) && Convert.ToBoolean(MAT135.IsChecked) && Convert.ToBoolean(SOC140.IsChecked) && 
                Convert.ToBoolean(ESP301.IsChecked) && Convert.ToBoolean(INF502.IsChecked) && Convert.ToBoolean(INF503.IsChecked) && Convert.ToBoolean(INF700.IsChecked) && Convert.ToBoolean(INF705.IsChecked) && Convert.ToBoolean(INF706.IsChecked) && Convert.ToBoolean(MAT145.IsChecked) && Convert.ToBoolean(SOC170.IsChecked) && 
                Convert.ToBoolean(IID725.IsChecked) && Convert.ToBoolean(INF241.IsChecked) && Convert.ToBoolean(INF810.IsChecked) && Convert.ToBoolean(INF840.IsChecked) && 
                Convert.ToBoolean(ADM910.IsChecked) && Convert.ToBoolean(IID830.IsChecked) && Convert.ToBoolean(INF021.IsChecked) && Convert.ToBoolean(INF411.IsChecked) && Convert.ToBoolean(INF412.IsChecked) && Convert.ToBoolean(INF450.IsChecked) && Convert.ToBoolean(INF910.IsChecked))
            {
                ADM900.IsEnabled = true;
                RowADM900.Fill = new SolidColorBrush(Colors.LightGreen);
                ADM900.IsEnabled = true;
                RowADM900.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                ADM900.IsEnabled = false;
                ADM900.IsChecked = false;
                RowADM900.Fill = new SolidColorBrush(Colors.Salmon);

            }
            if (Convert.ToBoolean(ADM900.IsChecked))
            {
                RowADM900.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //IID-945
            if (Convert.ToBoolean(MAT360.IsChecked))
            {
                IID945.IsEnabled = true;
                RowIID945.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                IID945.IsEnabled = false;
                IID945.IsChecked = false;
                RowIID945.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(IID945.IsChecked))
            {
                RowIID945.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-344 Y INF-345
            if(Convert.ToBoolean(INF411.IsChecked) && Convert.ToBoolean(INF412.IsChecked))
            {
                INF344.IsEnabled=true;
                RowINF344.Fill=new SolidColorBrush(Colors.LightGreen);
                INF345.IsEnabled = true;
                RowINF345.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF344.IsEnabled = false;
                INF344.IsChecked = false;
                RowINF344.Fill = new SolidColorBrush(Colors.Salmon);
                INF345.IsEnabled = false;
                INF345.IsChecked = false;
                RowINF345.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF344.IsChecked))
            {
                RowINF344.Fill=new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(INF345.IsChecked))
            {
                RowINF345.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-433
            if (Convert.ToBoolean(INF450.IsChecked))
            {
                INF433.IsEnabled = true;
                RowINF433.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF433.IsEnabled = false;
                INF433.IsChecked = false;
                RowINF433.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF433.IsChecked))
            {
                RowINF433.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-920
            if (Convert.ToBoolean(INF184.IsChecked) && Convert.ToBoolean(INF185.IsChecked) && Convert.ToBoolean(INF502.IsChecked) && Convert.ToBoolean(INF503.IsChecked))
            {
                INF920.IsEnabled = true;
                RowINF920.Fill=new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF920.IsEnabled = false;
                INF920.IsChecked = false;
                RowINF920.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF920.IsChecked))
            {
                RowINF920.Fill = new SolidColorBrush(Colors.LightBlue);
            }


            //DECIMO PRIMER CUATRIMESTRE
            //DPG-010
            if(Convert.ToBoolean(ADM900.IsChecked))
            {
                DPG010.IsEnabled = true;
                RowDPG010.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                DPG010.IsEnabled = false;
                DPG010.IsChecked = false;
                RowDPG010.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(DPG010.IsChecked))
            {
                RowDPG010.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //IID-025
            if (Convert.ToBoolean(IID945.IsChecked))
            {
                IID025.IsEnabled = true;
                RowIID025.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                IID025.IsEnabled = false;
                IID025.IsChecked = false;
                RowIID025.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(IID025.IsChecked))
            {
                RowIID025.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-025
            if (Convert.ToBoolean(INF705.IsChecked) && Convert.ToBoolean(INF706.IsChecked))
            {
                INF025.IsEnabled = true;
                RowINF025.Fill=new SolidColorBrush(Colors.LightGreen);
            }
            else 
            {
                INF025.IsEnabled = false;
                INF025.IsChecked = false;
                RowINF025.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF025.IsChecked))
            {
                RowINF025.Fill=new SolidColorBrush(Colors.LightBlue);
            }
            //INF-820
            if (Convert.ToBoolean(INF344.IsChecked) && Convert.ToBoolean(INF345.IsChecked))
            {
                INF820.IsEnabled = true;
                RowINF820.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF820.IsEnabled = false;
                RowINF820.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF820.IsChecked))
            {
                RowINF820.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //SOC-170
            if (Convert.ToBoolean(SOC160.IsChecked))
            {
                RowSOC160.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                RowSOC160.Fill = new SolidColorBrush(Colors.LightGreen);
            }


            //DECIMO SEGUNDO CUATRIMESTRE
            //INF-008
            if(Convert.ToBoolean(ADM900.IsChecked) && Convert.ToBoolean(IID945.IsChecked) && Convert.ToBoolean(INF344.IsChecked) && Convert.ToBoolean(INF345.IsChecked) && Convert.ToBoolean(INF433.IsChecked) && Convert.ToBoolean(INF920.IsChecked) && 
                Convert.ToBoolean(DPG010.IsChecked) && Convert.ToBoolean(IID025.IsChecked) && Convert.ToBoolean(INF025.IsChecked) && Convert.ToBoolean(INF820.IsChecked) && Convert.ToBoolean(SOC160.IsChecked) && 
                Convert.ToBoolean(IEL200.IsChecked) && Convert.ToBoolean(IEL205.IsChecked) && Convert.ToBoolean(INF022.IsChecked) && Convert.ToBoolean(INF023.IsChecked) && Convert.ToBoolean(INF024.IsChecked) && Convert.ToBoolean(INF026.IsChecked))
            {
                INF008.IsEnabled = true;
                RowINF008.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF008.IsEnabled = false;
                RowINF008.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF008.IsChecked))
            {
                RowINF008.Fill = new SolidColorBrush(Colors.LightBlue);
               // MessageBox.Show("Felicidades, has terminado la carrera");
            }

            //MATERIAS ELECTIVAS
            //IEL-200 Y IEL-205
            if (Convert.ToBoolean(IEL100.IsChecked) &&Convert.ToBoolean(IEL105.IsChecked))
            {
                IEL200.IsEnabled = true;
                RowIEL200.Fill = new SolidColorBrush(Colors.LightGreen);
                IEL205.IsEnabled = true;
                RowIEL205.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                IEL200.IsEnabled = false;
                IEL200.IsChecked = false;
                RowIEL200.Fill = new SolidColorBrush(Colors.Salmon);
                IEL205.IsEnabled = false;
                IEL205.IsChecked = false;
                RowIEL205.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(IEL200.IsChecked))
            {
                RowIEL200.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if (Convert.ToBoolean(IEL205.IsChecked))
            {
                RowIEL205.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-022
            if (Convert.ToBoolean(INF385.IsChecked) && Convert.ToBoolean(INF387.IsChecked))
            {
                INF022.IsEnabled = true;
                RowINF022.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF022.IsEnabled = false;
                INF022.IsChecked = false;
                RowINF022.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if (Convert.ToBoolean(INF022.IsChecked))
            {
                RowINF022.Fill=new SolidColorBrush(Colors.LightBlue);
            }
            //INF-023 Y INF-026
            if(Convert.ToBoolean(INF344.IsChecked) && Convert.ToBoolean(INF345.IsChecked))
            {
                INF023.IsEnabled = true;
                RowINF023.Fill = new SolidColorBrush(Colors.LightGreen);
                INF026.IsEnabled = true;
                RowINF026.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF023.IsEnabled = false;
                INF023.IsChecked = false;
                RowINF023.Fill = new SolidColorBrush(Colors.Salmon);
                INF026.IsEnabled = false;
                INF026.IsChecked = false;
                RowINF026.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF023.IsChecked))
            {
                RowINF023.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            if(Convert.ToBoolean(INF026.IsChecked))
            {
                RowINF026.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            //INF-024
            if(Convert.ToBoolean(INF225.IsChecked))
            {
                INF024.IsEnabled=true;
                RowINF024.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                INF024.IsEnabled = false;
                INF024.IsChecked = false;
                RowINF024.Fill = new SolidColorBrush(Colors.Salmon);
            }
            if(Convert.ToBoolean(INF024.IsChecked))
            {
                RowINF024.Fill = new SolidColorBrush(Colors.LightBlue);
            }
            
        }

        public void Exist(string path)
        {
            string jsonString = "{\"Primer\":[{\"name\":\"ESP-095\",\"status\":\"false\"},{\"name\":\"INF-117\",\"status\":\"false\"},{\"name\":\"ING-105\",\"status\":\"false\"},{\"name\":\"MAT-115\",\"status\":\"false\"},{\"name\":\"MAT-160\",\"status\":\"false\"},{\"name\":\"ORI-112\",\"status\":\"false\"},{\"name\":\"SOC-116\",\"status\":\"false\"},{\"name\":\"SOC-180\",\"status\":\"false\"}],\"Segundo\":[{\"name\":\"ESP-181\",\"status\":\"false\"},{\"name\":\"INF-164\",\"status\":\"false\"},{\"name\":\"INF-165\",\"status\":\"false\"},{\"name\":\"INF-204\",\"status\":\"false\"},{\"name\":\"ING-115\",\"status\":\"false\"},{\"name\":\"MAT-170\",\"status\":\"false\"},{\"name\":\"MAT-190\",\"status\":\"false\"},{\"name\":\"MAT-191\",\"status\":\"false\"},{\"name\":\"SOC-150\",\"status\":\"false\"}],\"Tercero\":[{\"name\":\"ESP-189\",\"status\":\"false\"},{\"name\":\"INF-121\",\"status\":\"false\"},{\"name\":\"INF-167\",\"status\":\"false\"},{\"name\":\"INF-168\",\"status\":\"false\"},{\"name\":\"ING-125\",\"status\":\"false\"},{\"name\":\"MAT-340\",\"status\":\"false\"},{\"name\":\"MAT-500\",\"status\":\"false\"},{\"name\":\"MAT-501\",\"status\":\"false\"},{\"name\":\"MED-750\",\"status\":\"false\"},{\"name\":\"MED-755\",\"status\":\"false\"}],\"Cuarto\":[{\"name\":\"IEL-100\",\"status\":\"false\"},{\"name\":\"IEL-105\",\"status\":\"false\"},{\"name\":\"INF-171\",\"status\":\"false\"},{\"name\":\"INF-172\",\"status\":\"false\"},{\"name\":\"INF-173\",\"status\":\"false\"},{\"name\":\"INF-385\",\"status\":\"false\"},{\"name\":\"INF-387\",\"status\":\"false\"},{\"name\":\"ING-165\",\"status\":\"false\"},{\"name\":\"MAT-350\",\"status\":\"false\"}],\"Quinto\":[{\"name\":\"DIB-520\",\"status\":\"false\"},{\"name\":\"IID-420\",\"status\":\"false\"},{\"name\":\"INF-440\",\"status\":\"false\"},{\"name\":\"INF-445\",\"status\":\"false\"},{\"name\":\"INF-481\",\"status\":\"false\"},{\"name\":\"INF-482\",\"status\":\"false\"},{\"name\":\"INF-535\",\"status\":\"false\"},{\"name\":\"MAT-360\",\"status\":\"false\"},{\"name\":\"SOC-700\",\"status\":\"false\"}],\"Sexto\":[{\"name\":\"INF-184\",\"status\":\"false\"},{\"name\":\"INF-185\",\"status\":\"false\"},{\"name\":\"INF-213\",\"status\":\"false\"},{\"name\":\"INF-214\",\"status\":\"false\"},{\"name\":\"INF-225\",\"status\":\"false\"},{\"name\":\"INF-331\",\"status\":\"false\"},{\"name\":\"MAT-135\",\"status\":\"false\"},{\"name\":\"SOC-140\",\"status\":\"false\"}],\"Septimo\":[{\"name\":\"ESP-301\",\"status\":\"false\"},{\"name\":\"INF-502\",\"status\":\"false\"},{\"name\":\"INF-503\",\"status\":\"false\"},{\"name\":\"INF-700\",\"status\":\"false\"},{\"name\":\"INF-705\",\"status\":\"false\"},{\"name\":\"INF-706\",\"status\":\"false\"},{\"name\":\"MAT-145\",\"status\":\"false\"},{\"name\":\"SOC-170\",\"status\":\"false\"}],\"Octavo\":[{\"name\":\"IID-725\",\"status\":\"false\"},{\"name\":\"INF-241\",\"status\":\"false\"},{\"name\":\"INF-810\",\"status\":\"false\"},{\"name\":\"INF-840\",\"status\":\"false\"}],\"Novena\":[{\"name\":\"ADM-910\",\"status\":\"false\"},{\"name\":\"IID-830\",\"status\":\"false\"},{\"name\":\"INF-021\",\"status\":\"false\"},{\"name\":\"INF-411\",\"status\":\"false\"},{\"name\":\"INF-412\",\"status\":\"false\"},{\"name\":\"INF-450\",\"status\":\"false\"},{\"name\":\"INF-910\",\"status\":\"false\"}],\"Decimo\":[{\"name\":\"ADM-900\",\"status\":\"false\"},{\"name\":\"IID-945\",\"status\":\"false\"},{\"name\":\"INF-344\",\"status\":\"false\"},{\"name\":\"INF-345\",\"status\":\"false\"},{\"name\":\"INF-433\",\"status\":\"false\"},{\"name\":\"INF-920\",\"status\":\"false\"}],\"DecimoPrimer\":[{\"name\":\"DPG-010\",\"status\":\"false\"},{\"name\":\"IID-025\",\"status\":\"false\"},{\"name\":\"INF-025\",\"status\":\"false\"},{\"name\":\"INF-820\",\"status\":\"false\"},{\"name\":\"SOC-160\",\"status\":\"false\"}],\"DecimoSegundo\":[{\"name\":\"INF-008\",\"status\":\"false\"}],\"Electivas\":[{\"name\":\"IEL-200\",\"status\":\"false\"},{\"name\":\"IEL-205\",\"status\":\"false\"},{\"name\":\"INF-022\",\"status\":\"false\"},{\"name\":\"INF-023\",\"status\":\"false\"},{\"name\":\"INF-024\",\"status\":\"false\"},{\"name\":\"INF-026\",\"status\":\"false\"}]}";
            if (File.Exists(path))
            {
                using (JsonDocument document = JsonDocument.Parse(File.ReadAllText("path")))
                {
                    JsonElement root= document.RootElement;
                    JsonElement primer = root.GetProperty("Primer");
                    JsonElement segundo = root.GetProperty("Segundo");
                    JsonElement tercer = root.GetProperty("Tercero");
                    JsonElement cuarto = root.GetProperty("Cuarto");
                    JsonElement quinto = root.GetProperty("Quinto");
                    JsonElement sexto = root.GetProperty("Sexto");
                    JsonElement septimo = root.GetProperty("Septimo");
                    JsonElement octavo = root.GetProperty("Octavo");
                    JsonElement novena = root.GetProperty("Novena");
                    JsonElement decimo = root.GetProperty("Decimo");
                    JsonElement decimo_Primer = root.GetProperty("Decimo Primer");
                    JsonElement decimo_Segundo = root.GetProperty("Decimo Segundo");
                    JsonElement electivas = root.GetProperty("Electivas");

                    foreach (JsonElement checkbox in primer.EnumerateArray())
                    {
                        if (Convert.ToString(checkbox.GetProperty("name")) == "ESP-095")
                        {
                            if (Convert.ToString(checkbox.GetProperty("status")) == "false")
                            {
                                ESP095.IsChecked = true;
                            }
                        } 
                    }

                }
            }
            else
            {
                File.WriteAllText(path, jsonString);
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Thread.Sleep(0);
        }

       
    }
}
