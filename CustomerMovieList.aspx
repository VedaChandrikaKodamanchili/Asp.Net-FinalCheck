<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/CustomerMaster.Master" CodeBehind="CustomerMovieList.aspx.cs" Inherits="Movie_Cruiser.CustomerMovieList"%>
 <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <p>
        &nbsp;<br />
                 </p>
                 <p> <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Movies</h2>
                     <asp:Panel ID="NotificationPanel" Visible="false" runat="server" Font-Bold="True" Font-Size="20px" ForeColor="#33CC33" HorizontalAlign="Center">Movie added to Favorites Successfully<br /> <br /></asp:Panel>
                      <asp:GridView ID="GridView1" runat="server" Width="959px" AutoGenerateColumns="false" CellPadding="5" CellSpacing="5" EnableTheming="True" GridLines="None" HorizontalAlign="Center" PageSize="1" RowHeaderColumn="Title" >
                       <Columns>
                <asp:BoundField HeaderText="Title" DataField="Title" />
                <asp:BoundField HeaderText="Box Office" DataField="BoxOffice" />
                <asp:BoundField HeaderText="Genre" DataField="Genre" />
                <asp:CheckBoxField HeaderText="Has Teaser" DataField="HasTeaser" />
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="~\CustomerMovieList.aspx?id={0}&ShowPanel=True" Text="Add to Favorite" HeaderText="Action" />
        </Columns>
          
    </asp:GridView>       
                 <p>
                     &nbsp;</asp:Content>