<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowMessage.aspx.cs" Inherits="SharePointPopups.Layouts.SharePointPopups.ShowMessage" DynamicMasterPageFile="~masterurl/default.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
    <Sharepoint:ScriptLink runat="server" Name="SP.js" Localizable="false"  ID="s1" LoadAfterUI="true"/>
    <Sharepoint:ScriptLink runat="server" Name="SP.Runtime.js" Localizable="false"  ID="s2" LoadAfterUI="true"/>
</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <%= MessageTitleQueryValue %>
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
    <%= MessageTitleQueryValue %>
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <div style="min-height: 150px; padding-bottom: 10px;">
        <span>
            <img style="float: left; width: 50px;" src="<%= MessageImageValue %>" alt="<%= MessageImageText %>"/>
        </span>
        <p style="margin-left: 60px; min-height: 100px;">
            <%= MessageContentValue %>
        </p>
    </div>
    <div style="text-align: right;">
        <% if (MessageButtonOptions.Equals("Ok"))
           { %>
            <asp:Button runat="server" ID="OkButton" Text="OK" OnClick="OkButton_OnClick"/>      
        <% }
           else if (MessageButtonOptions.Equals("OkCancel"))
           { %>
            <asp:Button runat="server" ID="OkButton1" Text="OK" OnClick="OkButton_OnClick"/> &nbsp;&nbsp;
            <asp:Button runat="server" ID="CancelButton" Text="Cancel" OnClick="CancelButton_OnClick"/>      
        <% } %>
        
    </div>
</asp:Content>