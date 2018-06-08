<%@ Page Title="Products" Language="C#" MasterPageFile="~/MasterPage/TropicalServer.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="TropicalServer.UI.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../AppThemes/TropicalStyles/Products.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="ProductGroup" runat="server" OnItemCommand="ProductGroup_ItemCommand">
        <HeaderTemplate>
              <table class="repeater-table">
              <tr>
                 <th class="bold white product-head">PRODUCT CATEGORIES</th>
              </tr>
          </HeaderTemplate>
          <ItemTemplate>
          <tr style="padding-top: 20px">
            <td style="background-color:#3690AA; color:white; text-align:center">
              <asp:LinkButton runat="server" ID="LinkButtons" Text='<%# Eval("ItemTypeDescription") %>' />       
            </td>
          </tr>
        </ItemTemplate>
    </asp:Repeater>
    <asp:GridView ID="ProductsTable"
        AutoGenerateColumns="False"
        EnableViewState="True"
        EmptyDataText="No data available."
        OnSelectedIndexChanging="ProductsTable_SelectedIndexChanging"
        runat="server"
        DataKeyNames="ItemID"
        CssClass="Grid"
        BorderColor="White" BorderStyle="Ridge" CellSpacing="1" CellPadding="3" 
        GridLines="None" BackColor="White" BorderWidth="2px"> 
        <AlternatingRowStyle BackColor="#EAEFF2" />
        <HeaderStyle CssClass="white" />
        <Columns>    
            <asp:BoundField DataField="ItemID" HeaderText="Item #"
                InsertVisible="False" ReadOnly="True"  SortExpression="ItemID" />
            <asp:BoundField DataField="ItemDescription" HeaderText="Item Description"
                InsertVisible="False" ReadOnly="True" SortExpression="ItemDescription" />
            <asp:BoundField DataField="PrePrice" HeaderText="Pre Price"
                SortExpression="PrePrice" />
            <asp:BoundField DataField="ItemWeights" HeaderText="Size"
                SortExpression="ItemWeights" />
        </Columns>
        <HeaderStyle BackColor="#3890A4" />
        <RowStyle BackColor="#D1DCE2" />
        <SortedDescendingHeaderStyle Wrap="False" />
    </asp:GridView>

</asp:Content>
