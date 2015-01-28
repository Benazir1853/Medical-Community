using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedicalCommunityAutomation.BLL;

namespace MedicalCommunityAutomation
{
    public partial class stockReport : System.Web.UI.Page
    {
        StockManager aStockManager = new StockManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //int centerId = (int)Session["center_Id"];
            int centerId = 2;
            showGridView.DataSource=aStockManager.GetAll(centerId);
            showGridView.DataBind();
        }
    }
}