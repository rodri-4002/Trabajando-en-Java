﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="CapaPresentacionWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Datos del Alumno<br />
        <br />
        <br />
        Apellidos:
        <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
        <br />
        <br />
        Nombres:<asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
        <br />
        <br />
        Edad:
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReporte" runat="server" Text="Reporte" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
