using Point_of_Sale_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Point_of_Sale_System
{
    public class PointOfSaleManager
    {
       
        public List<SalesCl> Sales { get; set; }
        //public List<SalesList> SalesList { get; set; }
        //public List<SalesDetails> SalesDetails { get; set; }

        
        public DataGrid SaleDataGrid { get; set; }
        //public DataGrid SaleListDataGrid { get; set; }
        //public DataGrid SaleDetailsDataGrid { get; set; }



       
        public bool Addsale(SalesCl sale)
        {
            try
            {
                if (Sales == null)
                    Sales = new List<SalesCl>();

                Sales.Add(sale);
                BindSale();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void BindSale()
        {
            SaleDataGrid.Items.Clear();

            if (Sales != null)
                foreach (var sale in Sales)
                {
                    SaleDataGrid.Items.Add(sale);
                }
        }

        //public bool AddSaleList(SalesList salesList)
        //{
        //    try
        //    {
        //        if (SalesList == null)
        //            SalesList = new List<SalesList>();

        //        SalesList.Add(salesList);
        //        BindSaleList();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public bool AddSaleDetails(SalesDetails salesDetail)
        //{
        //    try
        //    {
        //        if (SalesDetails == null)
        //            SalesDetails = new List<SalesDetails>();

        //        SalesDetails.Add(salesDetail);
        //        BindSaleDetails();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}


        ////<!--BINDING TO THE GRIDS ON THE WINDOW************************-->
        ////********************************************







        //public void BindSaleList()
        //{
        //    SaleListDataGrid.Items.Clear();

        //    if (SalesList != null)
        //        foreach (var sale in SalesList)
        //        {
        //            SaleListDataGrid.Items.Add(sale);
        //        }
        //}

        //public void BindSaleDetails()
        //{
        //    SaleDetailsDataGrid.Items.Clear();

        //    if (SalesDetails != null)
        //        foreach (var sale in SalesDetails)
        //        {
        //            SaleDetailsDataGrid.Items.Add(sale);
        //        }
        //}

        //<!-- END BINDING ************************-->

    }
}
