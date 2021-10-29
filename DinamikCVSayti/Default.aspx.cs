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

            DataSet1TableAdapters.TBL_BACARIQLARIMTableAdapter dt4 = new DataSet1TableAdapters.TBL_BACARIQLARIMTableAdapter();
            Repeater4.DataSource = dt4.BacariqlarList();
            Repeater4.DataBind();

            DataSet1TableAdapters.TBL_MARAQLARIMTableAdapter dt5 = new DataSet1TableAdapters.TBL_MARAQLARIMTableAdapter();
            Repeater5.DataSource = dt5.MaraqlarimList();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBL_MUKAFATLARIMTableAdapter dt6 = new DataSet1TableAdapters.TBL_MUKAFATLARIMTableAdapter();
            Repeater6.DataSource = dt6.MukafatlarimList();
            Repeater6.DataBind();
        }
    }
}