<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CvEntityProje.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>MESAJ DETAYLARI</h4>
    <asp:TextBox ID="TxtBoxGonderen" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtBoxMail" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtBoxKonu" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtBoxMesaj" TextMode="MultiLine" runat="server" Height="100" Enabled="false" CssClass="form-control"></asp:TextBox>
</asp:Content>
