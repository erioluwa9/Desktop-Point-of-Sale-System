using Point_of_Sale_System.Models;
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
using System.Windows.Shapes;

namespace Point_of_Sale_System
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        PointOfSaleContext db = new PointOfSaleContext();
        public static DataGrid dataGrid;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void CustomerSave_Click(object sender, RoutedEventArgs e)
        {
            var customer = new CustomerCl()
            {
                Name = customerName.Text,
                Email = email.Text,
                PhoneNumber = long.Parse(phoneNumber.Text)
            };

            db.Customer.Add(customer);
            db.SaveChanges();

            customerName.Clear();
            email.Clear();
            phoneNumber.Clear();

            MessageBox.Show("Customer Added Successfully", "Alert");
            //var stuf = new MainWindow();
            //stuf.ShowBiz.Content = new Sales();
            this.Hide();
            var sale = new Sales();
            sale.myCustomerComboBox.ItemsSource = db.Customer.ToList();
        }

        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
                
        private void TopBarCustomer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
