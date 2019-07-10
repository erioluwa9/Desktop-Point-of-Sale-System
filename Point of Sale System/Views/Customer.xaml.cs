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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Point_of_Sale_System
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Page
    {
        PointOfSaleContext db = new PointOfSaleContext();
        public static DataGrid dataGrid;

        
        public Customer()
        {
            InitializeComponent();
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            myCustomerDatagrid.ItemsSource = db.Customer.ToList();
            dataGrid = myCustomerDatagrid;
        }


        private void CustomerSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var customer = new CustomerCl()
                {
                    Name = customerName.Text,
                    Email = email.Text,
                    PhoneNumber = long.Parse(phoneNumber.Text)
                };

                db.Customer.Add(customer);
                db.SaveChanges();
                dataGrid.ItemsSource = db.Customer.ToList();


                customerName.Clear();
                email.Clear();
                phoneNumber.Clear();
            }
            catch (Exception)
            {

            
            }

           
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (myCustomerDatagrid.SelectedItem as CustomerCl).Id;
                var UpdateCustomer = db.Customer.Where(m => m.Id == Id).Single();

                UpdateCustomer.Name = customerName.Text;
                UpdateCustomer.Email = email.Text;
                UpdateCustomer.PhoneNumber = long.Parse(phoneNumber.Text);

                db.SaveChanges();
                dataGrid.ItemsSource = db.Customer.ToList();

                customerName.Clear();
                email.Clear();
                phoneNumber.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (myCustomerDatagrid.SelectedItem as CustomerCl).Id;
                var EditCustomer = db.Customer.Where(m => m.Id == Id).ToList();
                foreach (var item in EditCustomer)
                {
                    customerName.Text = item.Name.ToString();
                    email.Text = item.Email.ToString();
                    phoneNumber.Text = item.PhoneNumber.ToString();
                }
            }
            catch (Exception)
            {

            }

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (myCustomerDatagrid.SelectedItem as CustomerCl).Id;
                var deleteCustomer = db.Customer.Where(m => m.Id == Id).Single();


                db.Customer.Remove(deleteCustomer);


                db.SaveChanges();
                dataGrid.ItemsSource = db.Customer.ToList();
            }
            catch (Exception)
            {

            }
        }
    }
}
