using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Point_of_Sale_System.Models;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowBiz.Content = new Dashboard();
        }

        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TopBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            ShowBiz.Content = new Product();
            Display.Text = "PRODUCT";
        }

        private void Category_Click(object sender, RoutedEventArgs e)
        {
            ShowBiz.Content = new Category();
            Display.Text = "CATEGORY";
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            ShowBiz.Content = new Customer();
            Display.Text = "CUSTOMER";
        }

        private void Sale_Click(object sender, RoutedEventArgs e)
        {
            ShowBiz.Content = new Sales();
            Display.Text = "SALES";
        }

        private void SalesDetails_Click(object sender, RoutedEventArgs e)
        {
            ShowBiz.Content = new SaleList();
            Display.FontSize = 20;
            Display.Text = "SALES DETAILS";           
        }

        private void DashBoard_Click(object sender, RoutedEventArgs e)
        {
            ShowBiz.Content = new Dashboard();
            Display.Text = "DASHBOARD";
        }        
    }
}
