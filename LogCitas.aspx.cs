using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogCitas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fnLoadddlFiltro();
            fnLoadGridView_LogCitas();
        }
    }

    private void fnLoadddlFiltro()
    {
        dbControlDataContext con = new dbControlDataContext();
        try
        {
            var filtro = (from f in con.Categorias
                           select f);
            ddl_Filtro.DataSource = filtro;
            ddl_Filtro.DataTextField = "Nombre";
            ddl_Filtro.DataValueField = "PKCategoria";
            ddl_Filtro.DataBind();
            ddl_Filtro.SelectedValue = cUtilities.fnGetCookie("ddl_Filtro");
        }
        catch { }
    }

    protected void ddl_Filtro_SelectedIndexChanged(object sender, EventArgs e)
    {
        cUtilities.fnStCookie("ddl_Filtro", ddl_Filtro.SelectedValue);
        fnLoadGridView_LogCitas();
    }

    protected void fnLoadGridView_LogCitas()
    {

        try
        {
            dbControlDataContext con = new dbControlDataContext();
            var citas = (from ci in con.Citas
                         join cat in con.Categorias on ci.FKCategoria equals cat.PKCategoria
                         join al in con.Usuarios on ci.FKNControl equals al.NEmpleado
                         join em in con.Usuarios on ci.FKUsuario equals em.NEmpleado
                         where ci.Atendido == true
                         && ci.FKCategoria == Convert.ToInt32( ddl_Filtro.SelectedValue)
                         orderby ci.Date ascending
                         select new
                         {
                             PKNCita = ci.PKNCita,
                             FKNControl = ci.FKNControl,
                             Nombre = al.Nombre + " " + al.ApellidoP + " " + al.ApellidoM,
                             Servicio = cat.Nombre,
                             Date = ci.Date,
                             FKUsuario = em.NEmpleado,
                             NombreEmpleado = em.Nombre + " " + em.ApellidoP + " " + em.ApellidoM
                         });

            gvbLogCitas.DataSource = citas;
            gvbLogCitas.DataBind();
        }
        catch { }
    }
}