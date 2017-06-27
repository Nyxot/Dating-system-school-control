using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string year;
    public string hiddenMenu;
    public bool isLogin;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (cUtilities.fnGetCookie("IsLogin") == null || cUtilities.fnGetCookie("IsLogin") == "")
        {
            cUtilities.fnStCookie("IsLogin", "");
            lblUser_Login.Text = "Login";
            isLogin = false;
            Response.Redirect("~/Login.aspx");
        }
        if (cUtilities.fnGetCookie("Islogin") == "true")
        {
            lblUser_Login.Text = "User";
            isLogin = true;
            lblNTUser.Text = cUtilities.fnGetCookie("NC");
            lblNameUser.Text = cUtilities.fnGetCookie("Nombre") + " " + cUtilities.fnGetCookie("ApellidoP");
        }

        if (!IsPostBack)
        {
            year = "<p id=\"rights\"> &copy;&nbsp;Copyright " + DateTime.Now.Year.ToString() + "Powered by Student of ITSZAPOPAN</p>";

            if (cUtilities.fnGetCookie("IsLogin") == "")
            {
                cUtilities.fnStCookie("IsLogin", "");
                lblUser_Login.Text = "Login";
                isLogin = false;
            }
            if (cUtilities.fnGetCookie("Islogin") == "true")
            {
                lblUser_Login.Text = "User";
                isLogin = true;
                lblNTUser.Text = cUtilities.fnGetCookie("NC");
                lblNameUser.Text = cUtilities.fnGetCookie("Nombre") + " " + cUtilities.fnGetCookie("ApellidoP");
            }
        }
    }   

    public string LinesBelow()
    {
        return "<hr class=\"Blue-hr1\" /><hr class=\"Blue-hr2\" />";
    }
       
     protected void LogoutButton_Click(object sender, EventArgs e) 
    {
        int limit = Request.Cookies.Count; //Get the number of cookies and 
        //use that as the limit.
        HttpCookie aCookie;   //Instantiate a cookie placeholder
        string cookieName;

        //Loop through the cookies
        for (int i = 0; i < limit; i++)
        {
            cookieName = Request.Cookies[i].Name;    //get the name of the current cookie
            aCookie = new HttpCookie(cookieName);    //create a new cookie with the same
            // name as the one you're deleting
            aCookie.Value = "";    //set a blank value to the cookie 
            aCookie.Expires = DateTime.Now.AddDays(-1);    //Setting the expiration date
            //in the past deletes the cookie

            Response.Cookies.Add(aCookie);    //Set the cookie to delete it.
        }
        //cUtilities.fnStCookie("NC", "");
        //cUtilities.fnStCookie("Nombre", "");
        //cUtilities.fnStCookie("ApellidoP", "");
        //cUtilities.fnStCookie("ApellidoM", "");
        //cUtilities.fnStCookie("Puesto", "");        
        //cUtilities.fnStCookie("IsLogin", "");

        Response.Redirect("~/Login.aspx");
    }    
}
