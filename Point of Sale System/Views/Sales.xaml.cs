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
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Page
    {
        
        PointOfSaleContext db = new PointOfSaleContext();
        public static DataGrid dataGrid;
        PointOfSaleManager saleListList = new PointOfSaleManager();
        public Sales()
        {
            InitializeComponent();
            DataContext = this;
            saleListList.SaleDataGrid = this.mySalesDatagrid;
            saleListList.BindSale();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid = mySalesDatagrid;
            myCustomerComboBox.ItemsSource = db.Customer.ToList();
            myCategoryComboBox.ItemsSource = db.Category.ToList();
        }

        private void MyCategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Name = (myCategoryComboBox.SelectedItem as CategoryCl).Name;    
            var product = db.Product.Where(b => b.CategoryName == Name).ToList();

            try
            {
                myProductComboBox.ItemsSource = product.ToList(); ;
                myProductComboBox.DisplayMemberPath = "Name";

            }
            catch (Exception)
            {

            }
        }

        private void MyProductComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            { 
                string Name = (myProductComboBox.SelectedItem as ProductCl).Name;
                var QuantityLeft = db.Product.Where(b => b.Name == Name).Select(b => b.Quantity).ToList();
                foreach (var Quantity in QuantityLeft)
                {
                    if (Quantity == 0)
                    {
                        MessageBox.Show("Sorry, the product is not available! Please Re-Stock!", "Alert");
                    }
                    else if (Quantity < 10)
                    {
                        MessageBox.Show("The Quantity of this Product is less than 10, Please Re-Stock!!!", "Alert");
                        var productAmount = db.Product.Where(b => b.Name == Name).Select(b => b.Amount);
                        foreach (var item in productAmount)
                        {
                            price.Text = item.ToString();
                        }
                    }
                    else
                    {
                        var productAmount = db.Product.Where(b => b.Name == Name).Select(b => b.Amount);
                        foreach (var item in productAmount)
                        {
                            price.Text = item.ToString();
                        }

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void MyCustomerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Random TransID = new Random();
            int tal = TransID.Next(0, 500);
            transID.Text = tal.ToString();

            try
            {
                //myCategoryComboBox.SelectedIndex = -1;
                //myProductComboBox.SelectedIndex = -1;
                price.Clear();
                quantity.Clear();
                subTotal.Clear();

                
                saleListList.Sales.Clear();
                mySalesDatagrid.Items.Clear();
                //db.Sales.Clear();   

                amountDue.Clear();
                amountPaid.Clear();
                change.Clear();

            }
            catch (Exception)
            {

            }            
        }

        private void Quantity_SelectionChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                var value = myProductComboBox.Text;
                var cust = db.Product;

                var newPrice = decimal.Parse(price.Text);

                if (quantity.Text == "")
                {
                    quantity.Text = "1";
                }

                var newQuantity = decimal.Parse(quantity.Text);

                var avalQuantity = cust.Where(b => b.Name == value).Select(b => b.Quantity);
                foreach (var aQuantity in avalQuantity)
                    if (newQuantity > aQuantity)
                    {
                        MessageBox.Show("Sorry, Your input is more than what is Available! Please pick a number below " + aQuantity + ".", "Alert");
                    }
                    else
                    {
                        subTotal.Text = (newPrice * newQuantity).ToString();
                    }
            }
            catch(FormatException)
            {
                
            }
            catch (Exception)
            {

            }
        }

        private void Trans_Click(object sender, RoutedEventArgs e)
        {           
            //myCategoryComboBox.SelectedIndex = -1;
            //myProductComboBox.SelectedIndex = -1;
            price.Clear();
            quantity.Clear();
            subTotal.Clear();
        }

        private void SalesSaveToList_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
            
                var sale = new SalesCl
                {
                    CustomerName = myCustomerComboBox.Text,
                    TransID = int.Parse(transID.Text),
                    CategoryName = myCategoryComboBox.Text,
                    ProductName = myProductComboBox.Text,
                    Price = decimal.Parse(price.Text),
                    Quantity = int.Parse(quantity.Text),
                    TotalAmount = decimal.Parse(subTotal.Text),
                    DateTime = DateTime.Parse(dateOfSales.Text)
                };

            //db.Sales.Add(sale);
            //db.SaveChanges();
            //dataGrid.ItemsSource = db.Sales.ToList();
            saleListList.Addsale(sale);
            saleListList.BindSale();

                var saleList = new SalesList
                {
                    TransactionID = int.Parse(transID.Text),
                    ProductName = myProductComboBox.Text,
                    UnitPrice = decimal.Parse(price.Text),
                    Quantity = int.Parse(quantity.Text),
                    TotalAmount = decimal.Parse(subTotal.Text),
                };


                db.SaleList.Add(saleList);
                db.SaveChanges();
                

               // myCategoryComboBox.SelectedIndex = -1;
                //myProductComboBox.SelectedIndex = -1;
                price.Clear();
                quantity.Clear();
                subTotal.Clear();

            //var salesSum = db.Sales;
            var salesSum = saleListList.Sales;

            amountDue.Text = salesSum.Sum(g => g.TotalAmount).ToString();

                //Updating the new quantity value on the quantity page


                //var changeQuantity = db.Product.Where(b => b.Name == myProductComboBox.Text).ToList();
                //foreach (var item in changeQuantity)
                //{
                //    int newQuatity = int.Parse(quantity.Text) - item.Quantity;

                //    var chang = db.Product.Where(b => b.Name == myProductComboBox.Text).Select(b => b.Quantity).Single();
                //    chang = newQuatity;
                //    //item.Equals(chang);
                //}



                //}
            }
            catch (Exception)
            {

            }

        }

        private void AmouuntPaid_SelectionChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                var newAmountDue = decimal.Parse(amountDue.Text);
                
                var newAmountPaid = decimal.Parse(amountPaid.Text);

                change.Text = (newAmountPaid - newAmountDue).ToString();
            }

            catch (FormatException)
            {

            }
            catch (Exception)
            {

            }
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void SavePayment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var detail = new SalesDetails
                {
                    Name = myCustomerComboBox.Text,
                    TransactionID = int.Parse(transID.Text),
                    TotalAmountDue = decimal.Parse(amountDue.Text),
                    TotalPaid = decimal.Parse(amountPaid.Text),
                    Change = decimal.Parse(change.Text),
                    DateTime = DateTime.Parse(dateOfSales.Text)
                };

                db.SaleDetails.Add(detail);
                db.SaveChanges();
                

                //myCustomerComboBox.SelectedIndex = -1;
                transID.Clear();
                //myCategoryComboBox.SelectedIndex = -1;
                //myProductComboBox.SelectedIndex = -1;
                price.Clear();
                quantity.Clear();
                subTotal.Clear();

                saleListList.Sales.Clear();
                mySalesDatagrid.Items.Clear();
                //db.Sales.Clear();

                amountDue.Clear();
                amountPaid.Clear();
                change.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (mySalesDatagrid.SelectedItem as SalesCl).Id;
                var UpdateSales = saleListList.Sales.Where(m => m.Id == Id).Single();


                UpdateSales.TransID = int.Parse(transID.Text);
                UpdateSales.ProductName = myProductComboBox.Text;
                UpdateSales.Price = decimal.Parse(price.Text);
                UpdateSales.Quantity = int.Parse(quantity.Text);
                UpdateSales.TotalAmount = decimal.Parse(subTotal.Text);
                                
                saleListList.BindSale();
                

                transID.Clear();
                myProductComboBox.SelectedItem = null;
                price.Clear();
                quantity.Clear();
                subTotal.Clear();
                
            }
            catch (Exception)
            {

            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (mySalesDatagrid.SelectedItem as SalesCl).Id;
                var EditSales = saleListList.Sales.Where(m => m.Id == Id).ToList();
                foreach (var item in EditSales)


                {
                    transID.Text = item.TransID.ToString();
                    myProductComboBox.Text = item.ProductName.ToString();
                    price.Text = item.Price.ToString();
                    quantity.Text = item.Quantity.ToString();
                    subTotal.Text = item.TotalAmount.ToString();
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
                int Id = (mySalesDatagrid.SelectedItem as SalesCl).Id;
                var deleteSales = saleListList.Sales.Where(m => m.Id == Id).Single();


                saleListList.Sales.Remove(deleteSales);


                saleListList.BindSale();
                
            }
            catch (Exception)
            {

            }
        }

    }
}
