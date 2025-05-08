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

namespace NevekListboxban_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> nevek = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_szavakraBont_Click(object sender, RoutedEventArgs e)
        {
            
            if (tbx_nevekBe.Text != "")
            {
                nevek.Clear();
                String[] nevekTomb = tbx_nevekBe.Text.Split(',');

                foreach (string elem in nevekTomb) nevek.Add(elem);

                lb_nevek.Items.Clear();

                foreach (string elem in nevek) lb_nevek.Items.Add(elem);
            } else
            {
                MessageBox.Show("Nincs mit szavakra bontani!\nAdj meg neveket vesszővel elválasztva!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_rendez_Click(object sender, RoutedEventArgs e)
        {
            if (lb_nevek.Items.Count > 0)
            {
             
                lb_nevekRendezve.Items.Clear();
                nevek.Sort();

                foreach (string elem in nevek) lb_nevekRendezve.Items.Add(elem);
            }
            else
            {
                MessageBox.Show("Nincs mit sorbarendezni!\nAdj meg neveket vesszővel elválasztva!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
