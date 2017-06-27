using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrearCita : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblNControl.Text = cUtilities.fnGetCookie("NC");
            lblNombre.Text = cUtilities.fnGetCookie("Nombre")+" "+ cUtilities.fnGetCookie("ApellidoP")+" "+ cUtilities.fnGetCookie("ApellidoM");
            fnLoadddl_Categorias();
            fnLoadGridView_CrearCita();
        }
    }

    private void fnLoadddl_Categorias()
    {
        dbControlDataContext con = new dbControlDataContext();
        try
        {
            var categorias = (from c in con.Categorias
                              select c);
            ddl_Categorias.DataSource = categorias;
            ddl_Categorias.DataTextField = "Nombre";
            ddl_Categorias.DataValueField = "PKCategoria";
            ddl_Categorias.DataBind();
            ddl_Categorias.SelectedValue = cUtilities.fnGetCookie("ddl_Categoria");
        }
        catch { }
    }

    protected void fnLoadGridView_CrearCita()
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(ddl_Categorias.SelectedValue))
            {
                try
                {
                    dbControlDataContext con = new dbControlDataContext();
                    var citas = (from ci in con.Citas
                                 join cat in con.Categorias on ci.FKCategoria equals cat.PKCategoria
                                 where ci.FKNControl == Convert.ToInt32( cUtilities.fnGetCookie("NC"))
                                 && ci.Atendido == false
                                  orderby ci.Date ascending
                                  select new
                                  {
                                      PKNCita = ci.PKNCita,
                                      FKNControl = ci.FKNControl,
                                      Servicio = cat.Nombre,
                                      Date = ci.Date
                                      });

                    gvbCrearCita.DataSource = citas;
                    gvbCrearCita.DataBind();
                }
                catch { }
            }
        }
        catch { }
    }
    
    protected void addRow(object sender, EventArgs e)
    {
        dbControlDataContext con = new dbControlDataContext();
        Cita confi = new Cita();

        var exist = (from ex in con.Citas
                     where ex.Date == DateTime.Parse(RadDateTimePicker1.DbSelectedDate.ToString())
                     select ex);

        if (exist.Count() >=1 )
        {
            lb_Alert.Text = "Error, fecha y hora ya ocupadas";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "Alert", "$('#AlertPanel').modal();", true);
            AlertPanel.Update();
        }
        else
        {

            string addNControl = lblmodal_NControl.Text;
            string addServicio = ddl_Categorias.SelectedValue;


            if (!string.IsNullOrWhiteSpace(addNControl) && !string.IsNullOrWhiteSpace(addServicio))
            {
                try
                {
                    confi.FKNControl = Int32.Parse(addNControl);
                    confi.FKCategoria = Int32.Parse(addServicio);
                    confi.Date = DateTime.Parse(RadDateTimePicker1.DbSelectedDate.ToString());
                    confi.Atendido = false;
                    try
                    {
                        con.Citas.InsertOnSubmit(confi);
                        con.SubmitChanges();
                    }
                    catch
                    { }
                }
                catch
                { }

                fnLoadGridView_CrearCita();
                gvbCrearCita.DataBind();

            }
        }
        Response.Redirect(Request.RawUrl);
    }
       
    protected void ButtonRight_Click(object sender, EventArgs e)
    {
        lblModalTitle.Text = "Add New Record";
        lblmodal_NControl.Text = cUtilities.fnGetCookie("NC");
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        upModal.Update();
    }    
}