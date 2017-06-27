<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="CrearCita.aspx.cs" Inherits="CrearCita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentChildHead" runat="Server">
    <link href="CSS/CrearCita.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentChild" runat="Server">
    <script type="text/javascript">
        $("#ButtonSubMenu4").addClass("btn-outline-primary-active");
    </script>
    <div class="container-fluid Config-subcontainer" style="width: auto">
        <h2 style="margin-bottom: 0; text-align: center">Crear Cita</h2>
        <hr />
        <div>
            <div class="row in-line" style="margin-top: 30px;">
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
                </div>
                <%--<div class="col-sm-6">
                    <div class="container-fluid">
                        <p class="text-left" style="float: left;">Servicio:</p>
                        <asp:DropDownList ID="ddl_Categorias" runat="server" CssClass="form-control Control-inline " AutoPostBack="true" OnSelectedIndexChanged="ddl_Categorias_SelectedIndexChanged" />
                    </div>
                </div>--%>
            </div>
            <hr />
        </div>
        <div class="container-fluid Grid-Container">
            <asp:GridView ID="gvbCrearCita" runat="server" CssClass="table table-bordered" GridLines="None"               
                AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="ID" Visible="false">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ID" runat="server" Text='<%#Bind("PKNCita") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="N° Control" Visible="false">
                        <ItemTemplate>
                            <asp:Label ID="lbl_FKNControl" runat="server" Text='<%#Bind("FKNControl") %>'></asp:Label>
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
                                <div class="col-sm-4">
                                    <h5 class="modal-tittle text-center">N° Control</h5>
                                    <asp:Label ID="lblmodal_NControl" runat="server" CssClass="form-control form-control-modal"></asp:Label>
                                </div>
                                <div class="col-sm-4">
                                    <h5 class="modal-tittle text-center">Servicio: </h5>
                                    <asp:DropDownList ID="ddl_Categorias" runat="server" CssClass="form-control Control-inline " />
                                </div>
                                <div class="col-sm-4">
                                    <h5 class="modal-tittle text-center">Fecha</h5>
                                    <div id="timeslot">
                                        <telerik:RadDateTimePicker RenderMode="Lightweight" ID="RadDateTimePicker1" Width="100%" runat="server" DateInput-CssClass="radPreventDecorate">
                                        </telerik:RadDateTimePicker>
                                    </div>
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
        <div class="modal fade" id="Alert" role="dialog" aria-labelledby="myModalLabel"
            aria-hidden="true">
            <div class="modal-dialog">
                <asp:UpdatePanel ID="AlertPanel" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                    <ContentTemplate>
                        <div class="modal-content" style="margin: 200px auto auto -100px; width: 900px;">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                                    &times;</button>
                                <h4 class="modal-title">
                                    <asp:Label ID="lb_Alert" runat="server" Text=""></asp:Label></h4>
                            </div>                            
                            <div class="modal-footer">                                
                                <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">
                                    Close</button>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>
