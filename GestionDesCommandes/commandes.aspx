<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="commandes.aspx.cs" Inherits="GestionDesCommandes.commandes" %>

<%@ Register Src="~/ucCommande.ascx" TagPrefix="uc1" TagName="ucCommande" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
            .auto-style3 {
                font-size: xx-large;
                text-align: center;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <div class="auto-style2">
                <strong>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style3" ForeColor="#006699" Text="La liste des commandes effectuées" Width="100%"></asp:Label>
                </strong>
            </div><br /><br /><br />
            <asp:Repeater ID="Myrep" runat="server" OnItemCommand="Myrep_ItemCommand">
              <ItemTemplate>
                  <uc1:ucCommande runat="server" ID="ucCommande" /> <br/><br/><br/>
              </ItemTemplate>
            </asp:Repeater>
    </form>
</body>
</html>
