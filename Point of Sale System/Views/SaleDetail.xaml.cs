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
    /// Interaction logic for SaleList.xaml
    /// </summary>
    public partial class SaleList : Page
    {
        PointOfSaleContext db = new PointOfSaleContext();
        public static DataGrid dataGrid;

        public SaleList()
        {
            InitializeComponent();                        
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mySalesDetailsDatagrid.ItemsSource = db.SaleDetails.ToList();
            mySalesListDatagrid.ItemsSource = db.SaleList.ToList();

            //      mySalesListDatagrid.Items.Clear();
            
        }

        private void MySalesDetailsDatagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //mySalesListDatagrid.Items.Clear();

            SalesDetails d = mySalesDetailsDatagrid.SelectedItem as SalesDetails;
            
            try
            {
                var filtered = db.SaleList.Where(b => b.TransactionID == d.TransactionID).ToList();
                foreach (var item in filtered)
                {
                    mySalesListDatagrid.ItemsSource = filtered.ToList();
                }

            }
            catch (Exception)
            {

            }
        
        }
                
    }
}
