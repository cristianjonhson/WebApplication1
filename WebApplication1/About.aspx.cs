using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String cadenaConexion = "Data source=CRISTIAN; initial catalog=servicio;integrated security=true";
                SqlConnection conexionBD = new SqlConnection(cadenaConexion);
                conexionBD.Open();
                Label1.Text = "conexion exitosa";
            }
            catch (Exception ex)
            {
               Label1.Text = ex.Message;
            }
        }
    }
}