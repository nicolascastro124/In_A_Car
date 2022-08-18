<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="listarUsuarios.aspx.cs" Inherits="In_A_Car.listarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 32%
        }
        .auto-style2 {
            width: 294px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>

    <link href="css/login.css" rel="stylesheet" />


    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdLista" runat="server"
                AllowPaging="true" CssClass="table table-striped table-bordered table-hover"
                PageSize="6" OnPageIndexChanging="grdLista_SelectedIndexChanged">
            </asp:GridView>
            
            <br />

        </div>
        <div align ="center">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtBuscar" class="form-control" placeholder="Ingrese un rut" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnBuscar" class="btn btn-lg btn-primary btn-block btn-signin" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="text-center" colspan="2">
                        <asp:Label ID="lbMensaje" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    

</asp:Content>

