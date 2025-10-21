<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="SearhUser.aspx.vb" Inherits="MCAWARR.SearhUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    







        <asp:Label ID="lblName" runat="server" BackColor="#3399FF" 
            style="z-index: 1; left: 245px; top: 155px; position: absolute; height: 33px; width: 319px" 
            Text=" LIST OF USERS" Font-Size="Large"></asp:Label>
        </p>
    <p>
       
        <asp:Label ID="lblErrorMessage" runat="server" Font-Size="Small" 
            ForeColor="Red" 
            Visible="False" Font-Bold="True" 
            
            style="height: 19px; width: 696px; z-index: 1; left: 22px; top: 200px; position: absolute;"></asp:Label>

  
    </p>
    <p>
       
  
        &nbsp;</p>
    <p>
    







        <asp:Label ID="lblName0" runat="server" BackColor="White" 
            style="z-index: 1; left: 245px; top: 155px; position: absolute; height: 33px; width: 319px" 
            Text="  ADD NEW USER INFORMATION" Font-Size="Large" Font-Bold="True" 
            ForeColor="Black"></asp:Label>
    







        <asp:Label ID="lblName1" runat="server" BackColor="White" 
            style="z-index: 1; left: 245px; top: 155px; position: absolute; height: 33px; width: 319px" 
            Text="  LIST OF USERS" Font-Size="Large" Font-Bold="True" 
            ForeColor="Black"></asp:Label>
        <asp:GridView ID="grdsearch" runat="server" AllowPaging="True" 
            AutoGenerateSelectButton="True" BackColor="White" BorderColor="#999999" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" 
            ShowFooter="True">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Ridge" 
                Font-Bold="True" Font-Names="Verdana" ForeColor="Blue" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>

  
        <asp:Label ID="lblInfoMessage" runat="server" Font-Size="Small" 
            ForeColor="Blue" 
            Visible="False" Font-Bold="True" 
            
            
            style="height: 14px; width: 280px"></asp:Label>

  
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
