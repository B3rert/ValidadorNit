<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebFormNit.aspx.vb" Inherits="Nitvalidador02.WebFormNit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtNit" runat="server" Text ="12521337"></asp:TextBox>
        <asp:Button ID="btnValidNit" runat="server" Text="Validar Nit" />
    
    </div>
        <br />
        <asp:Label ID="lblValidNit" runat="server" Text=""></asp:Label>
        <p>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre: " Visible="false"></asp:Label>
            <asp:Label ID="lblNombre_R" runat="server" Text="" Visible="false"></asp:Label>
        </p>
        <asp:Label ID="lblDireccion" runat="server" Text="Dirección: " Visible="false"></asp:Label>
        <asp:Label ID="lblDireccion_R" runat="server" Text="" Visible="false"></asp:Label>
    </form>
</body>
</html>

