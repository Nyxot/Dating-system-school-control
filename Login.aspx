<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <title>edcore - Academia | Login</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1, user-scalable=no">
    <meta name="description" content="">
    <meta name="ITS Zapopan" content="">
    <!-- STYLESHEETS -->
    <!--[if lt IE 9]><script src="js/flot/excanvas.min.js"></script><script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script><script src="http://css3-mediaqueries-js.googlecode.com/svn/trunk/css3-mediaqueries.js"></script><![endif]-->
    <!-- FONTS -->
    <link href="~/CSS/cloud-admin.css" rel="stylesheet" />    
</head>
<body class="login">
    <form runat="server" style="height:914px; background-color: #666666">
    <!-- PAGE --><
    <section id="page" style="background-color: #666666">
        <!-- HEADER -->
        <header>
            <!-- NAV-BAR -->
            <div class="container">
                <div class="row">
                    <div class="col-md-4 col-md-offset-4">
                        <div id="logo">
                            <a href="#">
                                <img src="Images/logo.png" height="40" alt="edcore" /></a>
                        </div>
                    </div>
                </div>
            </div>
            <!--/NAV-BAR -->
        </header>
        <!--/HEADER -->
        <!-- LOGIN -->
        <section id="login_bg" class="visible">
            <div class="container">
                <div class="row">
                    <div class="col-md-4 col-md-offset-4">
                        <div class="login-box" style="background-color:#848484">
                            <h2 class="bigintro">Iniciar sesión</h2>
                            <div class="form-group">
                                <label>Matricula:</label>
                                <asp:TextBox ID="txtBoxNTUser" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="exampleInputPassword1">Password:</label>
                                <asp:TextBox TextMode="Password" ID="txtBoxPassword" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="container-fluid" style="display: block; margin: 5px auto">
                                <asp:Button ID="btnLogin" runat="server" Text="Sing in" CssClass="btn btn-primary btn-block" OnClick="btnLogin_Click"/>
                            </div>
                            <div class="container-fluid" style="display: block; margin: 5px auto">
                                <asp:Label ID="lblError" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>          
        </section>
        <!--/LOGIN -->
    </section>
</form>
</body>
</html>
