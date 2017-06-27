using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categorias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fnLoadGridView_Categorias();
        }
    }

    protected void fnLoadGridView_Categorias()
    {

        try
        {
            dbControlDataContext con = new dbControlDataContext();
            var categorias = (from cat in con.Categorias
                              orderby cat.Nombre ascending
                              select new
                              {
                                  PKCategoria = cat.PKCategoria,
                                  Nombre = cat.Nombre,
                                  Tiempo = cat.Tiempo
                              });

            gvbCategorias.DataSource = categorias;
            gvbCategorias.DataBind();
        }
        catch { }
    }
    protected void gvbCategorias_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //NewEditIndex property used to determine the index of the row being edited.        
        gvbCategorias.EditIndex = e.NewEditIndex;
        fnLoadGridView_Categorias();
        gvbCategorias.DataBind();
    }

    protected void gvbCategorias_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {        
        GridViewRow selectedRow = gvbCategorias.Rows[e.RowIndex];
        //Finding the controls from Gridview for the row which is going to update
        TextBox Nombre = (TextBox)selectedRow.FindControl("txt_Nombre");
        TextBox Tiempo = (TextBox)selectedRow.FindControl("txt_Tiempo");
        Label lbl_ID = (Label)selectedRow.FindControl("lbl_ID");


        using (dbControlDataContext con = new dbControlDataContext())
        {

            var categorias = (from cat in con.Categorias
                              where cat.PKCategoria == Convert.ToInt32(lbl_ID.Text)
                              select cat).FirstOrDefault();


            if (categorias != null)
            {
                //updating the record            
                categorias.Nombre = Nombre.Text;
                categorias.Tiempo = Convert.ToInt32(Tiempo.Text);

                try
                {
                    con.SubmitChanges();
                }
                catch { }

            }
        }

        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        gvbCategorias.EditIndex = -1;
        //Call ShowData method for displaying updated data  
        fnLoadGridView_Categorias();
        gvbCategorias.DataBind();
    }
    protected void gvbCategorias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        gvbCategorias.EditIndex = -1;
        fnLoadGridView_Categorias();
    }

    protected void addRow(object sender, EventArgs e)
    {
        dbControlDataContext con = new dbControlDataContext();
        Categoria confi = new Categoria();

        string addNombre = txt_addNombre.Text;
        string addTiempo = txt_addTiempo.Text;


        if (!string.IsNullOrWhiteSpace(addNombre) && !string.IsNullOrWhiteSpace(addTiempo))
        {
            try
            {
                confi.Nombre = addNombre;
                confi.Tiempo = Convert.ToInt32(addTiempo);
                try
                {
                    con.Categorias.InsertOnSubmit(confi);
                    con.SubmitChanges();
                }
                catch
                { }
            }
            catch
            { }

            fnLoadGridView_Categorias();
            gvbCategorias.DataBind();

        }
        Response.Redirect(Request.RawUrl);
    }

    protected void ButtonRight_Click(object sender, EventArgs e)
    {
        lblModalTitle.Text = "Add New Record";
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        upModal.Update();
    }
}