<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/TAIR.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%:Html.ActionLink("Year", "Details", "Test")%></h2>

<h2><%:Html.ActionLink("Month", "Create", "Test")%></h2>

</asp:Content>
