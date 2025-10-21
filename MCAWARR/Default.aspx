<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="MCAWARR._Default" %>

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
        
    <h2>
        Magistrate Court Accounting Warrant Application
    </h2>
    <table width="833px" border="0" cellpadding="10" cellspacing="15" >
    <tr align="left">
    <td valign="top" colspan="25" class="style2">
            <asp:Label ID="lblErrorMessage" runat="server" Font-Bold="True" 
                ForeColor="#FF3300" 
                style="z-index: 1; left: 47px; top: 212px; position: absolute; height: 19px; width: 315px"></asp:Label>
            <br />
            <br />
            <asp:LoginView ID="MainLoginView1" runat="server" EnableViewState="false">
                            <AnonymousTemplate>
                            <p> Please <a href="~/Account/Login.aspx" ID="HeadLoginStatus" runat="server">Log In</a> to access the application.</p>
                            </AnonymousTemplate>
                            <LoggedInTemplate>
                               <p>Welcome to the Magistrate Court Accounting Warrant Application. Click on the <b>Search </b>Tab to begin.</p>
                            </LoggedInTemplate>
            </asp:LoginView>
    </td>
    
    <td class="style2"><asp:Image ID="LogoImage2"  runat="server" 
            ImageUrl="~/Images/dekalbcountylogoltgry350.png" Height="290px" /></td>
    </tr>
    </table>
                    <%--<p>
        You must login in to access this application. 
    </p>--%>
    
</asp:Content>
