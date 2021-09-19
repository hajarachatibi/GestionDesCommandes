<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCommande.ascx.cs" Inherits="GestionDesCommandes.ucCommande" %>
<style type="text/css">
    .auto-style1 {
        text-align: left;
    }
    .auto-style2 {
        height: 23px;
        text-align: left;
    }
    .auto-style3 {
        color: #FF5050;
    }
    .auto-style4 {
        height: 23px;
        color: #FF5050;
    }
</style>
<table border=1 style="width:400px">
  <tr>
    <th><span class="auto-style4">Code</span> <span class="auto-style4">commande</span></th>
    <td>
        <strong>
        <asp:Label ID="lbcodecmd" runat="server" Text='<%# Eval("CodeCmd") %>'></asp:Label>
        </strong>
      </td>
  </tr>
  <tr>
    <th class="auto-style4">Date commande</th>
    <td class="auto-style2">
        <asp:Label ID="lbdatecmd" runat="server" Text='<%# Eval("DateCmd") %>'></asp:Label>
      </td>
  </tr>
  <tr>
    <th colspan="2" class="auto-style1">
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Click" CommandArgument='<%# Eval("CodeCmd") %>'>Détail</asp:LinkButton>
      </th>
  </tr>
</table>