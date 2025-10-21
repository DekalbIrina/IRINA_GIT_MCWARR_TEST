<%@ Page Title="Log In" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Login.aspx.vb" Inherits="MCAWARR.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 300px;
        }
    .style2
    {
        width: 363px;
    }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">


<table border="0" cellpadding="10" cellspacing="1" style="width: 833px">
    <tr align="left">
    <td valign="top" class="style2">
        <h2>
        Log In
       </h2>

        <%--<h2>
        Log In
    </h2>--%><%--<p>
        Please enter your username and password.
        <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false">Register</asp:HyperLink> if you don't have an account.
    </p>--%>
     <p>
        Please enter your username and password.
    </p>
    <asp:Login ID="LoginUser" runat="server" EnableViewState="False" 
            Height="98px" Width="395px" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#333333">
        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
        <LayoutTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Account Information</legend>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    
                </fieldset>
                <asp:Button ID="LoginButton" runat="server" CommandName="Login" 
                    ForeColor="#0033CC" Text="Log In" ValidationGroup="LoginUserValidationGroup" />
            </div>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
        </LayoutTemplate>
        <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
            BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
        <TextBoxStyle Font-Size="0.8em" />
        <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
            ForeColor="White" />
    </asp:Login>
    </td>
    <td class="style1">
        <asp:Image ID="LogoImage3"  runat="server" 
            ImageUrl="~/Images/dekalbcountylogoltgry350.png" 
            style="position: absolute; top: 166px; left: 594px; height: 313px; width: 340px; z-index: 1" /></td>
    
    </tr>
    </table>

        <h2>
       
        <asp:Label ID="lblLoginErrorMessage" runat="server" Font-Size="X-Small" 
            ForeColor="Red" 
            Visible="False"></asp:Label>
</h2>
        <asp:Label ID="lblDBError" runat="server" Font-Size="Small" 
            ForeColor="Red" 
            Visible="False" Font-Bold="True" 
        
        style="z-index: 1; left: 22px; top: 527px; position: absolute; width: 437px"></asp:Label>
</h2>


</asp:Content>