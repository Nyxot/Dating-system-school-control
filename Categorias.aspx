<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Categorias.aspx.cs" Inherits="Categorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentChildHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentChild" runat="Server">
    <script type="text/javascript">
        $("#ButtonSubMenu2").addClass("btn-outline-primary-active");
    </script>
    <div class="container-fluid Config-subcontainer" style="width: auto">
        <h2 style="margin-bottom: 0; text-align: center">Categorias</h2>
        <hr />
        <div>
            <%--<div class="row in-line" style="margin-top: 30px;">
                <div class="col-sm-6">
                    <div class="container-fluid">
                        <p class="text-left">
                            <span>N° Control:</span>
                            <asp:Label ID="lblNControl" runat="server"></asp:Label>
                        </p>
                        <p class="text-left">
                            <span>Alumno:</span>
                            <asp:Label ID="lblNombre" runat="server"></asp:Label>
                        </p>
                    </div>
            </div>--%>
        </div>
        <hr />
        <div class="container-fluid Grid-Container">
            <asp:GridView ID="gvbCategorias" runat="server" CssClass="table table-bordered" GridLines="None"
                AutoGenerateEditButton="true"
                OnRowEditing="gvbCategorias_RowEditing" OnRowCancelingEdit="gvbCategorias_RowCancelingEdit" OnRowUpdating="gvbCategorias_RowUpdating"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="ID" Visible="false">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ID" runat="server" Text='<%#Bind("PKCategoria") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lbl_Nombre" runat="server" Text='<%#Bind("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_Nombre" runat="server" Text='<%#Bind("Nombre") %>' CssClass="form-control"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tiempo">
                        <ItemTemplate>
                            <asp:Label ID="lbl_Tiempo" runat="server" Text='<%#Bind("Tiempo") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_Tiempo" runat="server" Text='<%#Bind("Tiempo") %>'></asp:TextBox>
                        </EditItemTemplate>
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
            <div style="float: right">
            <asp:Button ID="ButtonRight" runat="server" Text="Add" CssClass="btn btn-default btn-lg"
                OnClick="ButtonRight_Click" />
        </div>
            <asp:HiddenField ID="H1" runat="server" />
        </div>
    </div>
    <!-- Bootstrap Modal Dialog -->
    <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel"
        aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content" style="margin: 200px auto auto -100px; width: 900px;">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                                &times;</button>
                            <h4 class="modal-title">
                                <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                        </div>
                        <div class="row" style="margin-bottom: 20px">
                            <!-- cuerpo del modal-->
                            <div class="col-sm-6">
                                <h5 class="modal-tittle text-center">Nombre</h5>
                                <asp:TextBox ID="txt_addNombre" runat="server" CssClass="form-control form-control-modal"></asp:TextBox>
                            </div>
                            <div class="col-sm-6">
                                <h5 class="modal-tittle text-center">Tiempo (en milisegundos): </h5>
                                <asp:TextBox ID="txt_addTiempo" runat="server" CssClass="form-control form-control-modal"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="Button1" runat="server" OnClick="addRow" Text="ADD" CssClass="btn btn-info" />
                            <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">
                                Close</button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>

