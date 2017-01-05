using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportBarcodeRenderLab
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRender_Click(object sender, EventArgs e)
        {
            this.rv.LocalReport.ReportPath = "BarcodeLab.rdlc";
            this.rv.LocalReport.Refresh();

        }
    }
}