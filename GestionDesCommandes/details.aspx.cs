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
    public partial class details : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["MyDataBaseConnectionString"].ConnectionString + ";MultipleActiveResultSets=true";
        DCDataContext dc = new DCDataContext();
        commandes cmd = new commandes();
        string selectedlink;
        List<DataRow> listRows = new List<DataRow>();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
                selectedlink = cmd.value;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    lblcodecmd.Text = selectedlink;
                    lblcodecmd.Visible = true;
                    SqlDataAdapter da = new SqlDataAdapter("select DateCmd from MesCommandes where CodeCmd = '" + selectedlink + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    SqlDataReader readertest = da.SelectCommand.ExecuteReader();
                    readertest.Read();
                    string date = "" + readertest.GetValue(0);
                    lbldatecmd.Text = date;
                    lbldatecmd.Visible = true;
                    readertest.Close();

                    SqlDataAdapter da1 = new SqlDataAdapter("select CodeArt from Composition where CodeCmd =" + selectedlink + ";", con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    SqlDataReader reader = da1.SelectCommand.ExecuteReader();
                     while (reader.Read())
                     {

                        Object[] values = new Object[reader.FieldCount];
                        int nb = reader.GetValues(values);
                        for (int i = 0; i < nb; i++)
                        {
                            SqlCommand cmd = new SqlCommand("select Libelle, PU from Article where CodeArt = " + (int)reader.GetValue(i) + ";", con);
                            SqlDataReader rdr = cmd.ExecuteReader();
                            dt.Load(rdr);
                        }

                     }

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                    con.Close();
                }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("commandes.aspx");
        }

    }
}