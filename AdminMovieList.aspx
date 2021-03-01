<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminMovieList.aspx.cs" Inherits="MovieCruiser.AdminMovieList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="10" CellSpacing="2" GridLines="None" HorizontalAlign="Center" RowHeaderColumn="Id" >

        <Columns> 
         <asp:BoundField HeaderText="ID" DataField="Id" ItemStyle-Width="50px" />
           <asp:BoundField HeaderText="Title" DataField="Title" ItemStyle-Width="50px" />
       <asp:BoundField HeaderText="BoxOffice" DataField="BoxOffice" ItemStyle-Width="50px" />
        <asp:BoundField HeaderText="Active" DataField="Active" ItemStyle-Width="50px" />
      <asp:BoundField HeaderText="DateOfLaunch" DataField="DateOfLaunch" ItemStyle-Width="50px" />
      <asp:BoundField HeaderText="Genre" DataField="Genre" ItemStyle-Width="50px" />
      <asp:BoundField HeaderText="HasTeaser" DataField="HasTeaser" ItemStyle-Width="50px" />
      
      
       <asp:HyperLinkField
            DataNavigateUrlFields="id"
            DataNavigateUrlFormatString="~\EditMovie.aspx?id={0}"

            Text="Edit"
            HeaderText="Action" />
       </Columns>   
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="">
    </asp:LinqDataSource>
</asp:Content>
