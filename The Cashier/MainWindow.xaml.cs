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

namespace The_Cashier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator Calculator;
        public MainWindow()
        {
            InitializeComponent();
            Calculator = new Calculator();
            Listbox.ItemsSource = Calculator.getListItem();
        }
            private void AddButton_Click(object sender, RoutedEventArgs e)
            {
                string title = ItemNameBox.Text;
                int quantity = int.Parse(QuantityBox.Text);
                string type = TypeBox.Text;
                double price = double.Parse(PriceBox.Text);



                Item item = new Item(new Random().Next(), title, quantity, price, price, type);
                Calculator.addItem(item);
                double total = Calculator.getTotal();

                TotalLabel.Content = string.Format("Rp. {0}", total);

                Listbox.Items.Refresh();
            }
        }
    }
