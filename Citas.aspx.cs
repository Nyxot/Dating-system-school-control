using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

public partial class Citas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fnLoadGridView_Citas();
        }
    }
    protected void fnLoadGridView_Citas()
    {

        try
        {
            dbControlDataContext con = new dbControlDataContext();
            var citas = (from ci in con.Citas
                         join cat in con.Categorias on ci.FKCategoria equals cat.PKCategoria
                         join al in con.Usuarios on ci.FKNControl equals al.NEmpleado
                         where ci.Atendido == false
                         orderby ci.Date ascending
                         select new
                         {
                             PKNCita = ci.PKNCita,
                             FKNControl = ci.FKNControl,
                             Nombre = al.Nombre + " " + al.ApellidoP + " " + al.ApellidoM,
                             Servicio = cat.Nombre,
                             Date = ci.Date,
                             Atendido = ci.Atendido
                         });

            gvbCitas.DataSource = citas;
            gvbCitas.DataBind();
        }
        catch { }
    }
    protected void gvbCitas_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //NewEditIndex property used to determine the index of the row being edited.        
        gvbCitas.EditIndex = e.NewEditIndex;
        fnLoadGridView_Citas();
        gvbCitas.DataBind();
    }

    protected void gvbCitas_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow selectedRow = gvbCitas.Rows[e.RowIndex];
        //Finding the controls from Gridview for the row which is going to update
        RadDateTimePicker Reagendar =(RadDateTimePicker)selectedRow.FindControl("RadDateTimePicker1");
        CheckBox Atendido = (CheckBox)selectedRow.FindControl("chk_Atendido");
        Label lbl_ID = (Label)selectedRow.FindControl("lbl_ID");


        dbControlDataContext con = new dbControlDataContext();

        var citas = (from ci in con.Citas
                     where ci.PKNCita == Convert.ToInt32(lbl_ID.Text)
                     select ci).FirstOrDefault();


        if (citas != null)
        {
            //updating the record            
            citas.Atendido = Atendido.Checked;
            citas.FKUsuario = Convert.ToInt32(cUtilities.fnGetCookie("NC"));
            //citas.Date = DateTime.Parse( Reagendar.DbSelectedDate.ToString());
            con.SubmitChanges();

        }

        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        gvbCitas.EditIndex = -1;
        //Call ShowData method for displaying updated data  
        fnLoadGridView_Citas();
        gvbCitas.DataBind();
    }
    protected void gvbCitas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        gvbCitas.EditIndex = -1;
        fnLoadGridView_Citas();
    }
}