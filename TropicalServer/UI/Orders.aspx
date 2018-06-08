<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TropicalServer.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="TropicalServer.UI.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../AppThemes/TropicalStyles/Orders.css" rel="stylesheet" />
</asp:Content>
 <asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <asp:gridview id="OrdersTable" emptydatatext="No data available." 
          runat="server" AllowSorting="True" EnableViewState="True" CssClass="Grid" 
          AutoGenerateColumns="False"
          BorderColor="White" BorderStyle="Ridge" CellSpacing="1" CellPadding="3" 
          GridLines="None" BackColor="White" BorderWidth="2px"> 

        <AlternatingRowStyle BackColor="#EAEFF2" ForeColor="Black" />

        <Columns>
           <asp:BoundField DataField="OrderTrackingNumber" ControlStyle-Font-Bold="true" HeaderText="Tracking #" 
                InsertVisible="False" ReadOnly="True" SortExpression="ItemID">
                <ControlStyle Font-Bold="True"></ControlStyle>
            </asp:BoundField>
            <asp:BoundField DataField="OrderDate" HeaderText="Date"
                InsertVisible="False" ReadOnly="True" SortExpression="ItemDescription"/>
            <asp:BoundField  DataField="OrderCustomerNumber" HeaderText="Customer ID" 
                SortExpression="PrePrice" />
            <asp:BoundField DataField="CustName" HeaderText="Customer Name" 
                SortExpression="ItemWeights" />
            <asp:BoundField DataField="CustOfficeAddress1" HeaderText="Address" 
                SortExpression="ItemWeights" />
            <asp:BoundField DataField="CustRouteNumber" HeaderText="Routing #" 
                SortExpression="ItemWeights" />
            <asp:BoundField DataField="OrderId" HeaderText="Order Id" 
                SortExpression="ItemWeights" />
             <asp:TemplateField HeaderText="Available Actions" HeaderStyle-CssClass="white">
                <ItemTemplate>
                    <asp:Button ID="viewBtn" CommandArgument='btnView' runat="server" Text="View" OnClick="viewBtn_Click" />
                    <asp:Button ID="editBtn" CommandArgument='btnEdit' runat="server" Text="Edit" OnClick="editBtn_Click" />
                    <asp:Button ID="deleteBtn" CommandArgument='btnDelete' runat="server" Text="Delete" OnClick="deleteBtn_Click" />
                </ItemTemplate>

<HeaderStyle CssClass="white"></HeaderStyle>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle BackColor="#3890A4" />
        <RowStyle BackColor="#D1DCE2" ForeColor="Black" />
    </asp:gridview> 
     <div class="buttons">
        <asp:Button ID="prevBtn" OnClick="prevBtn_Click" runat="server" Text="<Prev" />
        <asp:Button ID="nextBtn" OnClick="nextBtn_Click" runat="server" Text="Next>" />
    </div>

</asp:Content>
