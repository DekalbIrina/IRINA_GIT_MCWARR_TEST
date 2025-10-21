<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AddNewUser.aspx.vb" Inherits="MCAWARR.AddNewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    







        <asp:Label ID="lblName" runat="server" 
            style="z-index: 1; left: 245px; top: 155px; position: absolute; height: 33px; width: 319px" 
            Text="  ADD  USER INFORMATION" Font-Size="Large" ForeColor="Black"></asp:Label>
        </p>
    <p>
        <asp:Label ID="lblErrorMessage"
            runat="server" BackColor="Red" BorderStyle="Ridge" Font-Bold="True" ForeColor="White"
            Height="39px" Visible="False" Width="608px" 
            style="z-index: 1; left: 24px; top: 194px; position: absolute"></asp:Label>
        </p>
    <asp:Label ID="lblUpdateSucess" runat="server" BackColor="PaleGreen" BorderStyle="Ridge"
            Font-Bold="True" ForeColor="Black" Height="39px" Visible="False" 
        Width="629px" style="z-index: 1; left: 109px; top: 197px; position: absolute"></asp:Label>
    <asp:TextBox ID="txtUserMidName" runat="server" Font-Bold="False" 
        
        style="z-index: 1; left: 605px; top: 255px; position: absolute; width: 220px" 
        TabIndex="2"></asp:TextBox>
    <br />
    <br />
    <asp:RequiredFieldValidator ID="ValLoginName" runat="server" 
        ControlToValidate="txtUserLoginName" 
        ErrorMessage="Please enter User Login Name" Font-Bold="True" 
        ForeColor="#FF3300" 
        style="z-index: 1; left: 599px; top: 314px; position: absolute; width: 207px"></asp:RequiredFieldValidator>
    <asp:TextBox ID="txtUserFirstName" runat="server" 
        
        style="z-index: 1; left: 202px; top: 256px; position: absolute; height: 19px; width: 222px" 
        TabIndex="1"></asp:TextBox>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:RequiredFieldValidator ID="ValLastName" runat="server" 
        ControlToValidate="txtUserLastName" ErrorMessage="Please enter Last Name" 
        Font-Bold="True" ForeColor="#FF3300" 
        style="z-index: 1; left: 201px; top: 319px; position: absolute; width: 174px"></asp:RequiredFieldValidator>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="ValFirstName" runat="server" 
        ControlToValidate="txtUserFirstName" ErrorMessage="Please enter First Name" 
        Font-Bold="True" ForeColor="#FF3300" 
        
        style="z-index: 1; left: 207px; top: 277px; position: absolute; width: 174px"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lblMName" runat="server" Font-Bold="True" ForeColor="Black" 
        style="z-index: 1; left: 460px; top: 258px; position: absolute; height: 16px; width: 139px" 
        Text="USER MIDDLE NAME"></asp:Label>
    <p>
        <asp:Label ID="lblUserFName" runat="server" 
            style="z-index: 1; left: 44px; top: 258px; position: absolute; width: 151px; height: 18px; right: 679px;" 
            Text="USER FIRST NAME*" Font-Bold="True" ForeColor="Black"></asp:Label>
        &nbsp;
        </p>
    <p>
        <asp:TextBox ID="txtUserLoginName" runat="server" 
            
            style="z-index: 1; left: 603px; top: 292px; position: absolute; width: 221px" 
            TabIndex="4"></asp:TextBox>
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label 
            ID="lblLName" runat="server" Font-Bold="True" ForeColor="Black" 
            style="z-index: 1; left: 46px; top: 298px; position: absolute; height: 19px; width: 140px" 
            Text="USER LAST NAME*"></asp:Label>
        <asp:TextBox ID="txtUserLastName" runat="server" Font-Bold="False" 
            
            
            style="z-index: 1; left: 202px; top: 295px; position: absolute; height: 19px; width: 225px" 
            TabIndex="3"></asp:TextBox>
        <asp:Label ID="lblUserLogName" runat="server" Font-Bold="True" 
            ForeColor="Black" 
            style="z-index: 1; left: 461px; top: 294px; position: absolute; width: 135px" 
            Text="USER LOGIN NAME*"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblJobTitle" runat="server" Font-Bold="True" ForeColor="Black" 
            style="z-index: 1; left: 49px; top: 338px; position: absolute; width: 127px" 
            Text="USER JOB TITLE"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtUserJobTitle" runat="server" 
            
            
            style="z-index: 1; left: 199px; top: 340px; position: absolute; width: 226px; right: 449px" 
            TabIndex="5"></asp:TextBox>
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblPermission" runat="server" 
            Font-Bold="True" ForeColor="Black" 
            style="z-index: 1; left: 464px; top: 337px; position: absolute; width: 114px" 
            Text="PERMISSION*"></asp:Label>
        <asp:Label ID="lblAddedDate" runat="server" Font-Bold="True" ForeColor="Black" 
            style="z-index: 1; left: 327px; top: 621px; position: absolute; width: 102px" 
            Text="ADDED DATE:"></asp:Label>
        <asp:Button ID="btnBacktoUserManag" runat="server" CausesValidation="False" 
            Font-Bold="True" ForeColor="Blue" 
            style="z-index: 1; left: 514px; top: 674px; position: absolute; width: 176px" 
            Text="LIST OF USERS" PostBackUrl="~/UserManager/SearhUser.aspx" 
            TabIndex="10" />
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="ddPermission" runat="server" 
            
            
            style="z-index: 1; left: 604px; top: 335px; position: absolute; height: 31px; width: 230px" 
            TabIndex="6">
            <asp:ListItem Value ="USER"> USER </asp:ListItem>
            <asp:ListItem Value ="ADMIN"> ADMIN </asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="lblAddedBy" runat="server" Font-Bold="True" ForeColor="Black" 
            style="z-index: 1; left: 48px; top: 621px; position: absolute; width: 78px" 
            Text="ADDED BY:"></asp:Label>
        <asp:Button ID="btnAddNewUser" runat="server" Font-Bold="True" ForeColor="Blue" 
            style="z-index: 1; left: 180px; top: 677px; position: absolute; width: 118px; right: 513px" 
            Text="ADD NEW USER" TabIndex="8" />
        <asp:Button ID="btnClear" runat="server" Font-Bold="True" ForeColor="Blue" 
            style="z-index: 1; left: 359px; top: 675px; position: absolute; width: 117px; right: 335px; height: 26px;" 
            Text="CLEAR" CausesValidation="False" TabIndex="9" />
        </p>
    <p>
        <asp:TextBox ID="txtAddDate" runat="server" 
            
            style="z-index: 1; left: 432px; top: 622px; position: absolute; width: 153px; right: 222px" 
            BorderWidth="0px" Font-Bold="True" ForeColor="Blue" ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="txtAddedBy" runat="server" 
            
            style="z-index: 1; left: 135px; top: 620px; position: absolute; width: 153px" 
            BorderWidth="0px" Font-Bold="True" ForeColor="Blue" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblComments" runat="server" 
            Font-Bold="True" ForeColor="Black" 
            style="z-index: 1; left: 48px; top: 385px; position: absolute; width: 126px; margin-bottom: 0px" 
            Text="COMMENTS"></asp:Label>
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtComments" 
            runat="server" Width="610px" 
            TextMode="MultiLine" TabIndex="7" 
            
            style="z-index: 1; left: 49px; top: 409px; position: absolute; height: 171px"></asp:TextBox>
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
