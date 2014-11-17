<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PopupDemoUserControl.ascx.cs" Inherits="SharePointPopups.Webparts.PopupDemo.PopupDemoUserControl" %>

<table>
    <thead>
        <tr>
            <td colspan="2">
                <h2>Popup Demo</h2>
            </td>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <asp:Button runat="server" ID="OKPopupButton" Text="OK Popup" OnClick="OKPopupButton_OnClick"/>
                <br/><br/>
                <asp:Button runat="server" ID="CancelPopupButton" Text="OK Cancel Popup" OnClick="CancelPopupButton_OnClick"/>
            </td>
            <td>
                <asp:Button runat="server" ID="OKRedirectPopupButton" Text="OK Popup with Redirect" OnClick="OKRedirectPopupButton_OnClick"/>
                <br/><br/>
                <asp:Button runat="server" ID="CancelRedirectPopupButton" Text="OK Cancel Popup with Redirect" OnClick="CancelRedirectPopupButton_OnClick"/>
            </td>
        </tr>
    </tbody>
</table>

<script src="/Style%20Library/Custom%20Scripts/PopupDemo.js" type="text/javascript"></script>