using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Text;
using System.Web.SessionState;
namespace Nisacreation
{
    public partial class SignIn : System.Web.UI.Page
    {
        int count = 0;
        String con;
        OdbcConnection conx;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void Button3_Click(object sender, EventArgs e)
        {


            //Server.Transfer("WebSiteNisa.aspx", true);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {


          



        }
    }
}