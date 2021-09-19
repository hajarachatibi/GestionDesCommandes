<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="GestionDesCommandes.details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            background-color: #009999;
        }
        .auto-style2 {
            width: 193px;
        }
        .auto-style3 {
            width: 371px;
        }
        .auto-style4 {
            font-size: large;
            color: #009999;
            text-align: center;
            margin-left: 221px;
            background-color: #CCCCCC;
        }
        .auto-style6 {
            width: 100%;
            text-align: left;
            color: #FF6666;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style8 {
            width: 193px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br /><br />
        <div>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Height="40px" Text="Back" Width="112px" OnClick="Button1_Click" />
        </div>
        <br /><br /><br />
        <table class="auto-style3" border="1">
            <tr>
                <th class="auto-style7"> Code de la commande </th>
                <td class="auto-style8">
                    <asp:Label ID="lblcodecmd" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <th> Date de la commande </th>
                <td class="auto-style2">
                    <asp:Label ID="lbldatecmd" runat="server"></asp:Label>
                </td>
            </tr>
        </table><br /><br /><br />
        <h3 class="auto-style6"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Liste des articles commandées:</em></h3>

        <asp:Panel ID="Panel1" runat="server" class="auto-style6" Width="579px">
            &nbsp;<asp:GridView ID="GridView1" runat="server" CssClass="auto-style4" Height="172px" Width="362px">
        </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
