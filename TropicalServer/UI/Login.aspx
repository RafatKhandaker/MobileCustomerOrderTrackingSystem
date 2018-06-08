<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TropicalServer.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TropicalServer.UI.Login" %>
<asp:Content ID="header" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../AppThemes/TropicalStyles/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" class="" runat="server">
    <div id="container" >
      <div id="BodyDetail">
          <label id="Loginlbl">Mobile Customer Order Tracking</label>
          <div id="errorBox"><label id="errorlbl"></label></div>
          <div id="loginBox">
              <asp:Label ID="useridlbl" CssClass="useridlbl" runat="server" Text="Login ID"/>
              <asp:TextBox ID="useridtextbox" runat="server" CssClass="useridtextbox"/>
                 <br/>
              <asp:Label ID="passwordlbl" CssClass="passwordlbl" runat="server">Password</asp:Label>
              <asp:TextBox ID="passwordtextbox" CssClass="passwordtextbox" runat="server"/>
               <div id="login">
                 <asp:Label ID="emailIDlbl"  CssClass="emailIDlbl" runat="server">Remember my ID</asp:Label><asp:CheckBox ID="remMeChBx" runat="server" OnCheckedChanged="remMeChBx_CheckedChanged" />
                 <asp:Button ID="loginButton" CssClass="loginButton" runat="server" Text="Log-in" OnClick="loginButton_Click" />
               </div>
          </div>
          <div id="forgot">
                <asp:Label ID="forgotUsername" CssClass="forgotUsername" runat="server"><a href="//">Forgot Username</asp:Label>
                <asp:Label ID="forgotPassword" CssClass="forgotPassword" runat="server"><a href="//">Forgot Password</a></asp:Label>
          </div>
      </div>
  </div>
</asp:Content>

