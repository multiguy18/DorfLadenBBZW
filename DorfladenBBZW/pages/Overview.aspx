<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overview.aspx.cs" Inherits="DorfladenBBZW.Pages.Overview" MasterPageFile="~/Shop.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="HeadPlaceholder">

</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceholder">
    <h2 class="description">Aktionen</h2>
    <asp:Repeater runat="server" ID="overviewContent">
        <ItemTemplate>
            <div class="products-sidebyside">
                <asp:Label runat="server" ID="lblID" Text='<%# Eval("Id") %>' />
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
