<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="UserMenu.aspx.vb" Inherits="MCAWARR.UserMenu" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style2
        {
            height: 325px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        
    
    <table width="833px" border="0" cellpadding="10" cellspacing="15" >
    <tr align="left">
    <td valign="top" colspan="25" class="style2">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblName" runat="server" Font-Bold="True" Font-Size="Large" 
                ForeColor="Black" Text="USER MANAGER MENU"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lnkAdduser" runat="server" Font-Bold="True" 
                PostBackUrl="~/UserManager/AddNewUser.aspx" Visible="False" 
                ForeColor="Black">ADD USER</asp:LinkButton>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblInfo" runat="server" BackColor="White" Font-Bold="True" 
                Font-Size="Large" ForeColor="#FF3300" 
                style="z-index: 1; left: 47px; top: 276px; position: absolute; width: 304px; height: 55px" 
                Text=" " Visible="False"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lnkUpdateUser" runat="server" Font-Bold="True" 
                ForeColor="Black" PostBackUrl="~/UserManager/SearhUser.aspx">SEARCH/UPDATE USER</asp:LinkButton>
    </td>
    
    <td class="style2">&nbsp;</td>
        <td class="style2"><asp:Image ID="LogoImage2"  runat="server" 
            ImageUrl="~/Images/dekalbcountylogoltgry350.png" Height="290px" /></td>
    </tr>
    </table>
                    <%--<p>
        You must login in to access this application. 
    </p>--%>
    
</asp:Content>

