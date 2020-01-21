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
using WpfAppIntroduktion.BIZ;

namespace WpfAppIntroduktion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ classBIZ = new ClassBIZ();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
            {
                listBox.ItemsSource = null;
            }
            listBox.Items.Clear();
        }

        private void ButtonOpg12_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave12(listBoxRes);
        }

        private void ButtonOpg13_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave13(listBoxRes);
        }

        private void ButtonOpg14_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave14(listBoxRes);
        }

        private void ButtonOpg15_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave15(listBoxRes);
        }

        private void ButtonOpg16_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave16(listBoxRes);
        }

        private void ButtonOpg17_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave17(listBoxRes);
        }

        private void ButtonOpg18_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            listBoxRes.ItemsSource = classBIZ.Delopgave18();
        }

        private void ButtonOpg19_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave19(listBoxRes);
        }

        private void ButtonOpg110_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave110(listBoxRes);
        }
    }
}
