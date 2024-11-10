using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            listView.Items.Add(counter);
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                listView.Items.Remove(listView.SelectedItem);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();
            counter = 0;
        }
    }
}
