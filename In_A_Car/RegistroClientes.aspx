<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroClientes.aspx.cs" Inherits="In_A_Car.RegistroUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <title></title>

    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>

    <link href="css/login.css" rel="stylesheet" />


    <style type="text/css">
        .auto-style3 {
            width: 288px;
        }
    </style>


</head>
<body>

    <div class="container">
        <div class="card card-container">
            <img id="avatar-img" class="avatar-img-card" src="img/avatarlogin.jpg" />
            <form class="form-signin" id="form1" runat="server">
                <table class="auto-style3">

                    <tr>
                        <td>
                            <asp:TextBox ID="txtId" class="form-control" placeholder="Ingrese su Rut" autofocus="autofocus" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtNombre" class="form-control" placeholder="Ingrese su Nombre" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtContraseña" TextMode="Password" class="form-control" placeholder="Ingrese su Contraseña" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtContraseña2" TextMode="Password" class="form-control" placeholder="Repita su Contraseña" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtCorreo" class="form-control" placeholder="Ingrese su Email" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtDireccion" class="form-control" placeholder="Ingrese su Dirección" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtNumero" class="form-control" placeholder="Ingrese su Número de Teléfono" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="text-center">
                            <asp:Label ID="lbMensaje" runat="server" ForeColor="#009933"></asp:Label><br />
                            <asp:Button class="btn btn-lg btn-primary btn-block btn-signin" ID="btnRegistrar" runat="server" Text="Registrarse" OnClick="btnRegistrar_Click" />
                            <br />
                            <asp:LinkButton ID="lnkReg" class="reg-lk" runat="server" OnClick="lnkReg_Click">¿Ya tienes una cuenta? Entra acá!</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>



</body>
</html>
