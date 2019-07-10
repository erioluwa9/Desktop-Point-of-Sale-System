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
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class Category : Page
    {
        PointOfSaleContext db = new PointOfSaleContext();
        public static DataGrid dataGrid;

        //int CatID = 0;
        public Category()
        {
            InitializeComponent();
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            myCategoryDatagrid.ItemsSource = db.Category.ToList();
            dataGrid = myCategoryDatagrid;
        }

        private void CategorySave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (categoryName.Text != "")
                {
                    var category = new CategoryCl()
                    {
                        Name = categoryName.Text
                    };

                    db.Category.Add(category);
                    db.SaveChanges();
                    myCategoryDatagrid.ItemsSource = db.Category.ToList();

                    categoryName.Clear();
                }
            }
            catch (Exception)
            {
               
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (myCategoryDatagrid.SelectedItem as CategoryCl).Id;
                var EditCategory = db.Category.Where(m => m.Id == Id).Single();

                EditCategory.Name = categoryName.Text;

                db.SaveChanges();
                dataGrid.ItemsSource = db.Category.ToList();

                categoryName.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (myCategoryDatagrid.SelectedItem as CategoryCl).Id;
                var EditCategory = db.Category.Where(m => m.Id == Id).Select(m => m.Name).ToList();

                foreach (var item in EditCategory)
                {
                    categoryName.Text = item.ToString();
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
                int Id = (myCategoryDatagrid.SelectedItem as CategoryCl).Id;
                var deleteCategory = db.Category.Where(m => m.Id == Id).Single();


                db.Category.Remove(deleteCategory);


                db.SaveChanges();
                dataGrid.ItemsSource = db.Category.ToList();
            }
            catch (Exception)
            {
                
            }
        }        
    }
}
