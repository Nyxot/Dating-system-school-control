<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="LogCitas.aspx.cs" Inherits="LogCitas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentChildHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentChild" runat="Server">
    <script type="text/javascript">
        $("#ButtonSubMenu3").addClass("btn-outline-primary-active");
    </script>
    <div class="container-fluid Config-subcontainer" style="width: auto">
        <h2 style="margin-bottom: 0; text-align: center">Log Citas</h2>
        <hr />
        <div>
            <div class="row in-line" style="margin-top: 30px;">
                <div class="col-sm-12">
                    <div class="container-fluid">
                        <p>
                            <span>Filtrar por:</span>
                        </p>
                        <asp:DropDownList ID="ddl_Filtro" runat="server" OnSelectedIndexChanged="ddl_Filtro_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control Control-inline"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <hr />
            <div class="container-fluid Grid-Container">
                <asp:GridView ID="gvbLogCitas" runat="server" CssClass="table table-bordered" GridLines="None"
                    AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="ID" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lbl_ID" runat="server" Text='<%#Bind("PKNCita") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="N° Control">
                            <ItemTemplate>
                                <asp:Label ID="lbl_FKNControl" runat="server" Text='<%#Bind("FKNControl") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nombre Alumno">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Nombre" runat="server" Text='<%#Bind("Nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Servicio">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Servicio" runat="server" Text='<%#Bind("Servicio") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Fecha" runat="server" Text='<%#Bind("Date") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="N° Empleado">
                            <ItemTemplate>
                                <asp:Label ID="lbl_NEmpleado" runat="server" Text='<%#Bind("FKUsuario") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nombre Empleado">
                            <ItemTemplate>
                                <asp:Label ID="lbl_EmpleadoNombre" runat="server" Text='<%#Bind("NombreEmpleado") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <AlternatingRowStyle BackColor="#dbefe1" />
                    <EditRowStyle BackColor="#e0e0e0" CssClass="grid-view-edit-row" Font-Size="Small"
                        Wrap="True" />
                    <HeaderStyle BackColor="#008a5e" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#f9f9f9" Font-Size="Small" />
                    <SelectedRowStyle Font-Bold="True" CssClass="info" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </div>
            <div style="margin-top: 15px; margin-bottom: 90px">
                <%--<div style="float: right">
            <asp:Button ID="ButtonRight" runat="server" Text="Add" CssClass="btn btn-default btn-lg"
                OnClick="ButtonRight_Click" />
        </div>--%>
                <asp:HiddenField ID="H1" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
