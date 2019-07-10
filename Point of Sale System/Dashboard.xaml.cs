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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        PointOfSaleContext db = new PointOfSaleContext();
        public static DataGrid dataGrid;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var totalCustomers = db.Customer.Count();
            customerDash.Text = totalCustomers.ToString();

            var totalProducts = db.Product.Count();
            productDash.Text = totalProducts.ToString();

            var totalPurchases = db.SaleDetails.Count();
            purchaseDash.Text = totalPurchases.ToString();

            var listofProfitableCustomers = db.SaleDetails.OrderByDescending(b => b.TotalAmountDue).Take(3).Skip(2).ToList();
            foreach (var item in listofProfitableCustomers)
            {
                listView.ItemsSource = item.Name.ToList();
            }
            

        }

    }

}
