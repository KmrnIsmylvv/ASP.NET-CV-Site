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


            DataSet1TableAdapters.TBL_TECRUBELERIMTableAdapter dt2 = new DataSet1TableAdapters.TBL_TECRUBELERIMTableAdapter();
            Repeater2.DataSource = dt2.TecrubeListi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBL_TEHSILTableAdapter dt3 = new DataSet1TableAdapters.TBL_TEHSILTableAdapter();
            Repeater3.DataSource = dt3.TehsilListi();
            Repeater3.DataBind();
        }
    }
}