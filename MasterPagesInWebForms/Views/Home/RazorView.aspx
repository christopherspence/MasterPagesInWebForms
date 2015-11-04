<%@ Page Language="C#" MasterPageFile="~/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="System.Web.Mvc" %>
<%@ Import Namespace="System.Web.Mvc.Html" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>I'm bout to render some Razor markup up in hurr.</h2>
    <% var html = Html.Partial((string)ViewBag._ViewName); %>
    <% Html.RenderPartial((string)ViewBag._ViewName); %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TitleContent" runat="server">
    <%   %>
</asp:Content>