using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WpfApplication1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var schedule = GetSchedule();

            this.DataContext = schedule;
        }

        private static List<Lecture> GetSchedule()
        {
            var mySchema = new List<Lecture> { 
                new Lecture { 
                    Subject = "Programmering", 
                    Time = new DateTime(2014, 6, 3)
                },
                new Lecture { 
                    Subject = "Programmering 2", 
                    Time = new DateTime(2014, 6, 3, 15,0,0) }
            };
            return mySchema;
        }
    }
}
