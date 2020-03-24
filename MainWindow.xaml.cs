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

namespace SQLiteApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
            DataAccess.AddData("Chewin Grerasitsirt");
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.AddData(txtAdd.Text);
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in DataAccess.GetData())
            {
                MessageBox.Show(data);
            }
        }
    }
}
