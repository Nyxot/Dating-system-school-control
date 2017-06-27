using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for cUtilities
/// </summary>
public class cUtilities
{
    public cUtilities()
    {
        //
        // TODO: Add constructor logic here
        //

    }
    public static string fnGetCookie(string cookieName)
    {
        System.Web.HttpCookie cooLan = HttpContext.Current.Request.Cookies[cookieName];
        if (cooLan == null || cooLan.Value == null)
        {
            return "";
        }
        else
        {

            return cooLan.Value;
        }
    }
    public static void fnStCookie(string cookieName, string value)
    {
        System.Web.HttpCookie Cook = new HttpCookie(cookieName, value);
        Cook.Expires = DateTime.Now.AddDays(365);
        HttpContext.Current.Response.Cookies.Add(Cook);
    }
}