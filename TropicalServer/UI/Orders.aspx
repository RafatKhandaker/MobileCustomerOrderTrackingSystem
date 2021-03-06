﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TropicalServer.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="TropicalServer.UI.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../AppThemes/TropicalStyles/Orders.css" rel="stylesheet" />
</asp:Content>
 <asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div id="filterActions" class="filter">
       <p>
           |   Order date:   <asp:DropDownList ID="fOrderDate" CssClass="o-filter" runat="server" OnSelectedIndexChanged="fOrderDate_SelectedIndexChanged"/>   |  
           Customer ID:   <asp:DropDownList ID="fCustomerID" CssClass="o-filter" runat="server" OnSelectedIndexChanged="fCustomerID_SelectedIndexChanged"/>   |
           Customer Name:   <asp:DropDownList ID="fCustomerName" CssClass="o-filter" runat="server" OnSelectedIndexChanged="fCustomerName_SelectedIndexChanged"/>   |
           Sales Manager:   <asp:DropDownList ID="fSalesManager" CssClass="o-filter" runat="server" OnSelectedIndexChanged="fSalesManager_SelectedIndexChanged"/>   |
      </p>
   </div>
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
                    <asp:Button ID="viewBtn" CommandArgument='View' runat="server" Text="View" OnClick="viewBtn_Click" />
                    <asp:Button ID="editBtn" CommandArgument='Edit' runat="server" Text="Edit" OnClick="editBtn_Click"/>
                    <asp:Button ID="deleteBtn" CommandArgument='Delete' runat="server" Text="Delete" OnClick="deleteBtn_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Available Actions" HeaderStyle-CssClass="white">
                 <EditItemTemplate>
                     <asp:Button ID="updateBtn" CommandArgument='Update' runat="server" Text="Update" />
                     <asp:Button ID="cancelBtn" CommandArgument='Cancel' runat="server" Text="Cancel" />
                 </EditItemTemplate>
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
