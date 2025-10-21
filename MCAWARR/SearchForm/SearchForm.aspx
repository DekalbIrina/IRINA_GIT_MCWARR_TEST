<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="SearchForm.aspx.vb" Inherits="MCAWARR.SearchForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   
   
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">   
        <br />
        <br style="z-index: 1; left: 22px; top: 270px; position: absolute" />
        <asp:Label ID="lblSearchSceen" runat="server" 
            style="z-index: 1; left: 250px; top: 156px; position: absolute; width: 269px; height: 23px" 
            Text="SEARCH WARRANT SCREEN" Font-Bold="False" 
            Font-Names="Times New Roman" Font-Size="Large" ForeColor="Black"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                        BackColor="White" BorderColor="Black" Font-Bold="True" Font-Italic="False" 
                        Font-Names="Times New Roman" Font-Size="Medium" 
            ForeColor="Black" Height="62px" 
                        Width="364px">
                        <asp:ListItem Value="1">Search By Defendant First And Last Name</asp:ListItem>
                         <asp:ListItem Value="3">Search By Plaintiff First And Last Name</asp:ListItem>
                        <asp:ListItem Value="2">Search By Warrant Number</asp:ListItem>                     
                    </asp:RadioButtonList>
                    <asp:Label ID="lblfirst" runat="server" BackColor="White" Font-Bold="True" 
                        ForeColor="Black" 
                        style="Z-INDEX: 101; LEFT: 401px; POSITION: absolute; TOP: 219px; width: 109px;" 
                        Text="First Name" Visible="False" Font-Names="times new roman,medium" 
                        Font-Size="Medium"></asp:Label>
                    <asp:Label ID="lbllast" runat="server" BackColor="White" Font-Bold="True" 
                        ForeColor="Black" 
                        style="Z-INDEX: 1; LEFT: 403px; POSITION: absolute; TOP: 245px; height: 16px; width: 82px; margin-bottom: 0px;" 
                        Text="Last Name" Visible="False" Font-Names="Times New Roman,Medium" 
                        Font-Size="Medium"></asp:Label>
                    <asp:Label ID="lblWarrantNumber" runat="server" BackColor="White" Font-Bold="True" 
                        Font-Size="Medium" ForeColor="Black" 
                        style="Z-INDEX: 103; LEFT: 402px; POSITION: absolute; TOP: 266px; width: 132px; height: 19px;" 
                        Text="Warrant Number" Visible="False" 
            Font-Names="Times New Roman,Medium"></asp:Label>                       
                    <asp:TextBox ID="txtLastName" runat="server" 
                                
                        
                        
                        
                        style="z-index: 1; left: 506px; top: 242px; position: absolute; width: 150px;" 
                        Visible="False" TabIndex="2"></asp:TextBox>
                        


                                            <asp:TextBox ID="txtFirstName" 
            runat="server" MaxLength="20" 
                        
                        
                        style="Z-INDEX: 104; LEFT: 505px; POSITION: absolute; TOP: 218px; width: 149px; margin-right: 0px;" 
                        tabIndex="1" Visible="False"></asp:TextBox>
                                  <asp:TextBox ID="txtWarrantNumber" runat="server" MaxLength="10"                                                             
                        style="Z-INDEX: 105; LEFT: 522px; POSITION: absolute; TOP: 264px; width: 149px;" 
                        Visible="False" BackColor="White" TabIndex="3"></asp:TextBox>
                          <asp:Button ID="btnsubmit" runat="server" Font-Bold="True" ForeColor="Navy" 
                        
            style="Z-INDEX: 100; LEFT: 436px; POSITION: absolute; TOP: 299px" tabIndex="4" 
                        Text="Submit Search" ToolTip="Submit Search" Width="120px" />
  
        <asp:Button ID="btClear" runat="server" Font-Bold="True" ForeColor="#000099" 
            style="z-index: 1; left: 590px; top: 299px; position: absolute; height: 26px; width: 119px" 
            Text="Clear" TabIndex="5" />
       
        <asp:Label ID="lblErrorMessage" runat="server" Font-Size="Small" 
            ForeColor="Red" 
            Visible="False" Font-Bold="True" 
            style="height: 19px; width: 696px"></asp:Label>

  
    <p>
       
        &nbsp;</p>
    <p>
       
        &nbsp;</p>
    <p>

  
        <asp:Label ID="lblInfoMessage" runat="server" Font-Size="Small" 
            ForeColor="Blue" 
            Visible="False" Font-Bold="True" 
            
            
            
            
            style="z-index: 1; left: 28px; top: 296px; position: absolute; height: 14px; width: 192px"></asp:Label>

        <asp:GridView ID="grdsearch" runat="server" AllowPaging="True" 
            AutoGenerateSelectButton="True" BackColor="White" BorderColor="#999999" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" 
            ondatabound="Page_Load" 
            ShowFooter="True" DataKeyNames="warrant_id" Visible="False">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" BorderColor="White" BorderStyle="None" 
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

  
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
       
        &nbsp;</p>
    

</asp:Content>
