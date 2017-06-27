using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class MasterPage2 : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }

    protected string fnLoadMenu()
    {
        string goBack = "";
        dbControlDataContext con = new dbControlDataContext();

        var Screen = (from p in con.Permisos
                      join s in con.Screens
                      on p.FKScreen equals s.PKScreen
                      where
                           p.FKPuesto == Convert.ToInt32(cUtilities.fnGetCookie("Puesto"))
                           && s.Available == true                      
                      select s);

        foreach (var parent in Screen)
        {
            goBack += "<li class=\"li-nav-buttons\"> <a href=\"" + parent.URL + "\"> <button runat=\"server\" id=\"ButtonSubMenu" + parent.PKScreen + "\" type=\"button\" class=\"btn btn-default btn-outline-primary\">" + parent.Nombre + "</button></a> <ul class=\"ul-btn\" id=\"ulbtn" + parent.PKScreen + "\">";
            goBack += "</ul></li>";
        }
        return goBack;
    }

    public string LinesBelow()
    {
        return "<hr class=\"Blue-hr1\" style=\"width: 100%; float:left; \" /><hr class=\"Blue-hr2\" style=\" width: 11%; float:left; \" />";
    }
}
