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
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        PointOfSaleContext db = new PointOfSaleContext();
        public static DataGrid dataGrid;

        public Product()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            myProductDatagrid.ItemsSource = db.Product.ToList();
            dataGrid = myProductDatagrid;
            myProductComboBox.ItemsSource = db.Category.ToList();
        }

        private void SaveProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                var product = new ProductCl()
                {
                    Name = productName.Text,
                    CategoryName = myProductComboBox.Text,
                    Amount = decimal.Parse(amount.Text),
                    Quantity = int.Parse(quantity.Text)
                };

                db.Product.Add(product);
                db.SaveChanges();
                dataGrid.ItemsSource = db.Product.ToList();

                productName.Clear();
                amount.Clear();
                quantity.Clear();
                myProductComboBox.SelectedIndex = -1;
            }
            catch (Exception)
            {

            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (myProductDatagrid.SelectedItem as ProductCl).Id;
                var UpdateProduct = db.Product.Where(m => m.Id == Id).Single();

                UpdateProduct.Name = productName.Text;
                UpdateProduct.Quantity = int.Parse(quantity.Text);
                UpdateProduct.Amount = decimal.Parse(amount.Text);
                UpdateProduct.CategoryName = myProductComboBox.Text;

                db.SaveChanges();
                dataGrid.ItemsSource = db.Product.ToList();

                productName.Clear();
                quantity.Clear();
                amount.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (myProductDatagrid.SelectedItem as ProductCl).Id;
                var EditProduct = db.Product.Where(m => m.Id == Id).ToList();
                foreach (var item in EditProduct)
                {
                    productName.Text = item.Name.ToString();
                    quantity.Text = item.Quantity.ToString();
                    amount.Text = item.Amount.ToString();
                    myProductComboBox.Text = item.CategoryName.ToString();
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
                int Id = (myProductDatagrid.SelectedItem as ProductCl).Id;
                var deleteProduct = db.Product.Where(m => m.Id == Id).Single();


                db.Product.Remove(deleteProduct);


                db.SaveChanges();
                dataGrid.ItemsSource = db.Product.ToList();
            }
            catch (Exception)
            {

            }
        }
    }
}
