using Np.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NwProject
{
    public partial class Dashboard : System.Web.UI.Page
    {
        PurchaseManager _purchaseManager = new PurchaseManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridviewSupplyer();
            GridviewShalf();
            GridviewMedicine();
            GetQuantity();
            GridviewMedicineQty();
            GetPertoo();
            Gridviewpurchasettt();
            GetSeeellsrtoo();
            GridviewSealstttooo();
        }
        public void GridviewSupplyer()
        {
            decimal SubTotal = 0;
            foreach (GridViewRow row in gridSupplyer.Rows)
            {
                SubTotal = gridSupplyer.Rows.Count;
            }
            lblSupplyer.Text = SubTotal.ToString();
        }
        public void GridviewShalf()
        {
            decimal SubTotal = 0;
            foreach (GridViewRow row in gridShalf.Rows)
            {
                SubTotal = gridShalf.Rows.Count;
            }
            lblShalf.Text = SubTotal.ToString();
        }
        public void GridviewMedicine()
        {
            decimal SubTotal = 0;
            foreach (GridViewRow row in gridMedicine.Rows)
            {
                SubTotal = gridMedicine.Rows.Count;
            }
            lblMedicine.Text = SubTotal.ToString();
        }
        public void GetQuantity()
        {
            //try
            //{
            //    //var subject = _purchaseManager.GetMedicine();
            //    gridQuantity.DataSource = subject;
            //    gridQuantity.DataMember = "Quantity";
            //    gridQuantity.DataBind();
            //}
            //catch (Exception e)
            //{
            //    lblMedicine.Text = e.Message;
            //}
        }
        public void GetPertoo()
        {
            //try
            //{
            //    var subject = _purchaseManager.GetPurchTot();
            //    gridPurTotel.DataSource = subject;
            //    gridPurTotel.DataMember = "GrandTotal";
            //    gridPurTotel.DataBind();
            //}
            //catch (Exception e)
            //{
            //    lblMedicine.Text = e.Message;
            //}
        }
        public void GetSeeellsrtoo()
        {
            //try
            //{
            //    var subject = _purchaseManager.GetSeallsTot();
            //    gridSellsGd.DataSource = subject;
            //    gridSellsGd.DataMember = "GrandTotal";
            //    gridSellsGd.DataBind();
            //}
            //catch (Exception e)
            //{
            //    lblMedicine.Text = e.Message;
            //}
        }
        public void GridviewMedicineQty()
        {
            decimal SubTotal = 0;
            foreach (GridViewRow row in gridQuantity.Rows)
            {
                SubTotal = SubTotal + Convert.ToDecimal(row.Cells[0].Text);
            }
            lblQuantityTotal.Text = SubTotal.ToString();
        }
        public void Gridviewpurchasettt()
        {
            decimal SubTotal = 0;
            foreach (GridViewRow row in gridPurTotel.Rows)
            {
                SubTotal = SubTotal + Convert.ToDecimal(row.Cells[0].Text);
            }
            lblGDPTotal.Text = SubTotal.ToString();
        }
        public void GridviewSealstttooo()
        {
            decimal SubTotal = 0;
            foreach (GridViewRow row in gridSellsGd.Rows)
            {
                SubTotal = SubTotal + Convert.ToDecimal(row.Cells[0].Text);
            }
            lblStooo.Text = SubTotal.ToString();
        }

    }
}