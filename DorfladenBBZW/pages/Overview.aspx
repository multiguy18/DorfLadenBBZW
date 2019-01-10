<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overview.aspx.cs" Inherits="DorfladenBBZW.Pages.Overview" MasterPageFile="~/Shop.Master" %>
<%@ Import Namespace="DorfladenBBZW.TypeExtensions" %>
<asp:Content runat="server" ContentPlaceHolderID="HeadPlaceholder">

</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceholder">
    <h2 class="description">Aktionen</h2>
    <div class="overview-margin">
        <asp:Repeater runat="server" ID="overviewContent">
            <ItemTemplate>
                <a href='<%# Response.ApplyAppPathModifier(string.Format("Details.aspx?id={0}", Eval("Id"))) %>' class="link-no-deco">
                    <div class="products-sidebyside">
                        <asp:Image ImageUrl='<%# string.Format("~/img/{0}", Eval("ImageName")) %>' Height="300px" runat="server"/>
                        <br />
                        <asp:Label Text='<%# Eval("Name") %>' runat="server" CssClass="description" />
                        <br />
                        <asp:Label Text='<%# Eval("SpecialOffer").EvalToDecimalFormat() %>' runat="server" CssClass="description" />
                        <asp:Label Text='<%# Eval("OriginalPrice").EvalToDecimalFormat() %>' runat="server" CssClass="price-margin-left old-price" />
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
