using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionDesCommandes;
using System.Web.UI.HtmlControls;
using System.Data.Linq;
using System.Web.DynamicData;

namespace GestionDesCommandes
{
    public partial class commandes : System.Web.UI.Page
    {
        public static string detailselected;
        string cs = ConfigurationManager.ConnectionStrings["MyDataBaseConnectionString"].ConnectionString + ";MultipleActiveResultSets=true";
        DCDataContext dc = new DCDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            ucCommande uc1 = LoadControl("ucCommande.ascx") as ucCommande;
            Myrep.DataSource = dc.MesCommandes;
            Myrep.DataBind();
        }
        protected void Myrep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Click":
                    detailselected = e.CommandArgument.ToString();
                    string url = "~/details.aspx";
                    Response.Redirect(url);
                    break;
            }
        }
        public string value
        {
            get { return detailselected; }
        }
    }
}