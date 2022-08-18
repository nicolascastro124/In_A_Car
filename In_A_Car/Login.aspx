<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="In_A_Car.Login" %>

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
            font-size: small;
            background-color: #FFFFFF;
        }
    </style>

</head>

<body>

    <div class="container">
        <div class="card card-container">
            <img id="avatar-img" class="avatar-img-card" src="img/avatarlogin.jpg" />
            <form class="form-signin" id="form1" runat="server">
                <div class="text-center">
                <asp:TextBox ID="txtId" class="form-control" placeholder="Ingrese su Rut" autofocus="autofocus" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtContraseña" class="form-control" TextMode="Password" placeholder="Ingrese su contraseña" runat="server"></asp:TextBox>
                <strong>
                    <asp:Label ID="lbMensaje" runat="server" CssClass="auto-style3" ForeColor="#CC0000"></asp:Label>
                </strong>
                <br />
                <asp:Button class="btn btn-lg btn-primary btn-block btn-signin" ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
                <strong>
                    <asp:Label ID="lbLogin" runat="server" CssClass="auto-style3" ForeColor="#CC0000"></asp:Label>
                </strong>
                <br />
                <asp:LinkButton ID="lnkReg" class="reg-lk" runat="server" OnClick="lnkReg_Click">¿Aún no tienes una cuenta? Registrate!</asp:LinkButton>
                <br />
                <asp:LinkButton ID="lnkLoginAdmib" runat="server" OnClick="lnkLoginAdmib_Click">¿Eres Administrador?</asp:LinkButton>
                </div>
            </form>
        </div>
    </div>

</body>

</html>