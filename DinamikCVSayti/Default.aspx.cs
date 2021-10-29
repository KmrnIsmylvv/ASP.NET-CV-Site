using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DinamikCVSayti
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HAQQIMDATableAdapter dt = new DataSet1TableAdapters.TBL_HAQQIMDATableAdapter();
            Repeater1.DataSource = dt.HaqqimdaListele();
            Repeater1.DataBind();
        }
    }
}