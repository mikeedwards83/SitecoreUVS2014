<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sample Sublayout.ascx.cs" Inherits="Summit2015.Layouts.Sample_Sublayout" %>


<h1>
    <%=Editable(Model,x =>x .Title) %> - Rocks on Glass
</h1>

<%=Editable(Model, x=>x.Text) %>