using System;
using System.Collections;
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

namespace SORTEDLIST_HOMEWORK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList = new SortedList();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string dataShow = "";
            if (txtKey.Text == "" || txtValue.Text == "") 
            {
                MessageBox.Show("กรุณากรอกข้อมูล");
            }
            else {
                sortedList.Add(txtKey.Text, txtValue.Text);
                ICollection collection = sortedList.Keys;
                foreach (string sh in collection)
                {
                    dataShow = dataShow + sortedList[sh].ToString()+"\n";
                }
                MessageBox.Show(dataShow);
            }
        }
    }
}
