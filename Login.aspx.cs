using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        string user = this.txtBoxNTUser.Text.ToString();
        string pass = this.txtBoxPassword.Text.ToString();

        try
        {   
            dbControlDataContext con = new dbControlDataContext();
            var us = (from r in con.Usuarios
                      where r.NEmpleado == Convert.ToInt32(user)
                      && r.Contraseña == pass
                      select r).FirstOrDefault();

            if (us == null)
            {
                this.lblError.Text = "You don't have permission";
                this.txtBoxNTUser.Focus();
                this.txtBoxPassword.Attributes["value"] = "";
            }
            else
            {

                cUtilities.fnStCookie("NC", us.NEmpleado.ToString());
                cUtilities.fnStCookie("Nombre", us.Nombre.ToString());
                cUtilities.fnStCookie("ApellidoP", us.ApellidoP.ToString());
                cUtilities.fnStCookie("ApellidoM", us.ApellidoM.ToString());
                cUtilities.fnStCookie("Puesto", us.FKPuesto.ToString());
                cUtilities.fnStCookie("IsLogin", "true");


                Response.Redirect("~/ControlCitas.aspx");

            }
        }
        catch
        {
            this.lblError.Text = "You don't have permission";
            this.txtBoxNTUser.Focus();
            this.txtBoxPassword.Attributes["value"] = "";
        }

    }
}