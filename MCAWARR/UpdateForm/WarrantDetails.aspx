<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WarrantDetails.aspx.vb" Inherits="MCAWARR.WarrantViewUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<td>
<br style="z-index: 1; left: 22px; top: 270px; position: absolute" />
        <br />
    <br />
        <br style="z-index: 1; left: 22px; top: 270px; position: absolute" />
        <asp:Label ID="lblSearchSceen" runat="server" 
            style="z-index: 1; left: 255px; top: 158px; position: absolute; width: 269px; height: 23px" 
            Text="WARRANT DETAILS SCREEN" Font-Bold="False" 
            Font-Names="Times New Roman" Font-Size="Large" ForeColor="Black"></asp:Label>
        <br />
    <br />
    <br />
        <br />
    
        <asp:Label ID="lblUpdateSucess" runat="server" BackColor="PaleGreen" BorderStyle="Ridge"
            Font-Bold="True" ForeColor="Black" Visible="False" 
        style="z-index: 1; left: 205px; top: 185px; position: absolute; height: 28px; width: 352px;"></asp:Label>
 
        <asp:Label ID="lblErrorMessage"
            runat="server" BackColor="Red" BorderStyle="Ridge" Font-Bold="True" ForeColor="White"
            Height="39px" Visible="False" Width="608px" 
            style="z-index: 1; left: 250px; top: 182px; position: absolute"></asp:Label>
  
        <asp:Label ID="lblWarantNum" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="WARRANT NUMBER" 
            
            
            
        
        style="z-index: 1; left: 32px; top: 234px; position: absolute; width: 141px;"></asp:Label>
  
        <asp:TextBox ID="txtWarrantNum" runat="server" BackColor="White" 
            Height="20px" Width="127px" ReadOnly="True" Font-Bold="True" 
            BorderWidth="0px" ForeColor="Blue" 
            style="z-index: 1; left: 30px; top: 255px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblApplDate" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="APPLICATION DATE" Width="142px" 
            style="z-index: 1; left: 211px; top: 236px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtApplDate" runat="server" BackColor="White" 
            Height="20px" Width="127px" ReadOnly="True" Font-Bold="True" 
            BorderWidth="0px" ForeColor="Blue" 
            
            
        
        style="z-index: 1; left: 213px; top: 258px; position: absolute; right: 512px;"></asp:TextBox>
        <asp:Label ID="lbdDefMiddName" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="DEFENDANT  MIDDLE NAME" 
            
            
            
        
        style="z-index: 1; left: 569px; top: 289px; position: absolute; width: 191px; height: 17px"></asp:Label>
        <asp:Label ID="lbdDefFirstName" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="DEFENDANT  FIRST NAME" 
            
            
            
        
        style="z-index: 1; left: 34px; top: 291px; position: absolute; width: 163px"></asp:Label>
        <asp:TextBox ID="txtDefLast" runat="server" BackColor="White" 
            BorderColor="White" BorderWidth="0px" 
            Font-Bold="True" ForeColor="Blue" ReadOnly="True" 
            
            
            
            
        
        style="z-index: 1; left: 265px; top: 311px; position: absolute; width: 233px; height: 16px"></asp:TextBox>
        <asp:Label ID="lblDefAddress" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="DEFENDANT ADDRESS" 
            
            
            
        style="z-index: 1; left: 31px; top: 344px; position: absolute; height: 17px; width: 151px"></asp:Label>
        <asp:TextBox ID="txtDeffAddress" runat="server" BackColor="White" Height="16px" 
            BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" 
            
            
            
        style="margin-left: 0px; z-index: 1; left: 192px; top: 346px; position: absolute; width: 592px;"></asp:TextBox>
   
        <asp:TextBox ID="txtDefMiddle" runat="server" BackColor="White" 
            BorderColor="White" BorderWidth="0px" 
            Font-Bold="True" ForeColor="Blue" ReadOnly="True" 
            
            
            
        
        style="z-index: 1; left: 570px; top: 310px; position: absolute; width: 213px; height: 16px"></asp:TextBox>
        <asp:TextBox ID="txtDefFirst" runat="server" BackColor="White" 
            BorderColor="White" BorderWidth="0px" 
            Font-Bold="True" ForeColor="Blue" ReadOnly="True" 
            
            
            
            
        
        style="z-index: 1; left: 32px; top: 313px; position: absolute; width: 201px; right: 619px; height: 15px"></asp:TextBox>
        <asp:Label ID="lbdDefLastName0" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="DEFENDANT  LAST NAME" 
            
            
            
        
        style="z-index: 1; left: 266px; top: 292px; position: absolute; width: 163px; height: 17px"></asp:Label>
        <asp:Label ID="lblPlaitMiddleName" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="PLAINTIFF MIDDLE  NAME" 
            
            
            
        style="z-index: 1; left: 568px; top: 389px; position: absolute; height: 16px; width: 174px"></asp:Label>
        <asp:TextBox ID="txtPlainLastName" runat="server" BackColor="White" 
            BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" 
            
            
            
        style="z-index: 1; left: 258px; top: 409px; position: absolute; width: 251px; right: 343px; height: 15px;"></asp:TextBox>
        <asp:Label ID="lblPlaitFirstName" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="PLAINTIFF FIRST  NAME" 
            
            
            
        style="z-index: 1; left: 31px; top: 386px; position: absolute; height: 16px; width: 157px"></asp:Label>
        <asp:Label ID="lblPlaitLastName0" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="PLAINTIFF LAST NAME" 
            
            
            
        style="z-index: 1; left: 256px; top: 387px; position: absolute; height: 16px; width: 157px"></asp:Label>
    
        <asp:TextBox ID="txtPlainFirstName" runat="server" BackColor="White" 
            Height="15px" BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" 
            
            
            
        style="z-index: 1; left: 31px; top: 407px; position: absolute; width: 185px"></asp:TextBox>
        <asp:TextBox ID="txtPlaintAddress" runat="server" BackColor="White" 
            Height="16px" BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" 
            
            
        style="z-index: 1; left: 182px; top: 436px; position: absolute; width: 602px;"></asp:TextBox>
   
        <asp:TextBox ID="txtPlainMiddleName" runat="server" BackColor="White" 
            Height="15px" BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" 
            
            
            
        style="z-index: 1; left: 571px; top: 411px; position: absolute; width: 218px"></asp:TextBox>
  
        <asp:TextBox ID="txtWarrantAmt" runat="server" 
            BackColor="White" Height="15px" BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" ReadOnly="True" 
            
            
            style="z-index: 1; left: 215px; top: 500px; position: absolute; width: 120px;"></asp:TextBox>
        <asp:TextBox ID="txtWarrJudgeName" 
            runat="server" BackColor="White" Height="14px" BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" ReadOnly="True" 
            
            
            style="z-index: 1; left: 512px; top: 501px; position: absolute; margin-bottom: 0px; width: 202px;"></asp:TextBox> 
        <asp:Label ID="lblWarrJudgeName" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="WARRANT JUDGE NAME" Width="181px" 
            style="z-index: 1; left: 506px; top: 479px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtWarrantDate" 
            runat="server" BackColor="White" Height="14px" BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" ReadOnly="True" 
            
            
            style="z-index: 1; left: 364px; top: 500px; position: absolute; margin-bottom: 0px; width: 106px;"></asp:TextBox> 
        <asp:Label ID="lblWarrLocation" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="WARRANT LOCATION" 
            
            
            style="z-index: 1; left: 30px; top: 532px; position: absolute; width: 211px"></asp:Label>
 
        <asp:Label ID="lblPlainAddress" 
            runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="PLAINTIFF ADDRESS" 
            
            
            
        style="z-index: 1; left: 33px; top: 438px; position: absolute; height: 17px; width: 142px"></asp:Label>
        <asp:Label ID="lblWarrantAmount" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" Text="WARRANT AMOUNT"
            Width="129px" 
            style="z-index: 1; left: 216px; top: 478px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtWarrantLocation" runat="server" BackColor="White"
            Height="14px" Width="394px" BorderWidth="0px" 
            Font-Bold="True" ForeColor="Blue" ReadOnly="True" 
            style="z-index: 1; left: 30px; top: 550px; position: absolute"></asp:TextBox> 
        <asp:Label ID="lblApplJudgeName" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="APPLICATION JUDGE NAME" 
            
            style="z-index: 1; left: 22px; top: 685px; position: absolute; width: 211px; height: 19px"></asp:Label>
        <asp:Label ID="lblWarDisposition" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="WARRANT DISPOSITION" 
            
            style="z-index: 1; left: 453px; top: 530px; position: absolute; width: 211px"></asp:Label>
  
        <asp:Label ID="lblWarrantDate" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" Text="WARRANT DATE"
            Width="129px" 
            style="z-index: 1; left: 363px; top: 479px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtWarrantPhone1" runat="server" BackColor="White" 
            
            style="z-index: 1; left: 27px; top: 499px; position: absolute; height: 17px; width: 144px" 
            BorderStyle="None" Font-Bold="True" ForeColor="Blue"></asp:TextBox>
   
        <asp:TextBox ID="txtWarrDisposition" runat="server" BackColor="White" Height="13px"
            Width="312px" BorderWidth="0px" Font-Bold="True" 
            ForeColor="Blue" ReadOnly="True" 
            
            style="z-index: 1; left: 448px; top: 548px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:TextBox ID="txtWarrantCharge" runat="server" BorderWidth="0px" 
            Font-Bold="True" ForeColor="Blue" Width="758px" 
            BackColor="White" 
            
            style="z-index: 1; left: 161px; top: 577px; position: absolute; height: 20px"></asp:TextBox>
  
        <asp:Label ID="lblWarrantPhone1" runat="server" BackColor="White" Font-Bold="False"
            Font-Size="Small" ForeColor="Black" Text="WARRANT PHONE NUMBER" 
        
               style="z-index: 1; left: 27px; top: 480px; position: absolute; width: 177px; height: 16px"></asp:Label>
   
        <asp:Label ID="lblWarrCharge0" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="WARRANT CHARGE" 
            
            style="z-index: 1; left: 28px; top: 578px; position: absolute; width: 124px; height: 19px"></asp:Label>
        <asp:Label ID="lblOffCharge" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="OFFENSE CHARGE" 
            
            style="z-index: 1; left: 28px; top: 632px; position: absolute; width: 125px; height: 19px"></asp:Label>
 
        <asp:Label ID="lblApplAmt" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="APPLICATION AMT" 
            
            style="z-index: 1; left: 251px; top: 685px; position: absolute; width: 126px; height: 19px; right: 422px"></asp:Label>
        <asp:Label ID="lblDismDate" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="DISMISSAL DATE" 
            
            style="z-index: 1; left: 536px; top: 684px; position: absolute; width: 126px; height: 19px"></asp:Label>
        <asp:Label ID="lblDismAmt0" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="DISMISSAL AMT" 
            
            style="z-index: 1; left: 395px; top: 685px; position: absolute; width: 126px; height: 19px"></asp:Label>

            <asp:TextBox 
            ID="txtappJudgeName" runat="server" 
            
            
                
                style="z-index: 1; left: 27px; top: 704px; position: absolute; height: 19px; width: 194px; right: 742px;" 
                BorderWidth="0px" Font-Bold="True" ForeColor="Blue" ReadOnly="True" 
                BackColor="White"></asp:TextBox>
        <asp:TextBox ID="txtApplAmt" runat="server" 
            
            
            style="z-index: 1; left: 254px; top: 659px; position: absolute; height: 18px; width: 122px; margin-bottom: 27px; margin-top: 44px;" 
            BorderWidth="0px" Font-Bold="True" ForeColor="Blue" ReadOnly="True" 
            BackColor="White"></asp:TextBox>
        <asp:TextBox ID="txtDismisAmt" runat="server" 
            
            
            style="z-index: 1; left: 396px; top: 706px; position: absolute; height: 16px; width: 117px" 
            BorderWidth="0px" Font-Bold="True" ForeColor="Blue" ReadOnly="True" 
            BackColor="White"></asp:TextBox>

        <asp:TextBox ID="txtDismisDate" runat="server" 
            
            
            
            style="z-index: 1; left: 537px; top: 706px; position: absolute; height: 16px; width: 127px" 
            BorderWidth="0px" Font-Bold="True" ForeColor="Blue" ReadOnly="True" 
            BackColor="White"></asp:TextBox>
        <asp:Label ID="lblComment" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="COMMENTS" 
            
            style="z-index: 1; left: 29px; top: 954px; position: absolute; width: 404px; height: 19px"></asp:Label>
        <asp:Label ID="lblDockDate" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="DOCKET DATE" 
            
            style="z-index: 1; left: 26px; top: 765px; position: absolute; width: 126px; height: 19px"></asp:Label>
        <asp:TextBox ID="txtOffenceCharge" runat="server" BorderWidth="0px" 
            Font-Bold="True" ForeColor="Blue" Width="758px" BackColor="White" 
            style="z-index: 1; left: 178px; top: 631px; position: absolute"></asp:TextBox>
 
        <asp:TextBox ID="txtDockDate1" runat="server" TabIndex="1" BackColor="White" 
            style="z-index: 1; left: 25px; top: 794px; position: absolute"></asp:TextBox>
 
        <asp:TextBox ID="txtDockDate2" runat="server" TabIndex="3" BackColor="White" 
            style="z-index: 1; left: 25px; top: 825px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="txtDockDate3" runat="server" TabIndex="5" BackColor="White" 
            style="z-index: 1; left: 25px; top: 848px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDocDescr3" runat="server" Width="480px" TabIndex="6" 
            BackColor="White" 
            style="z-index: 1; left: 185px; top: 846px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="txtDockDate4" runat="server" TabIndex="7" BackColor="White" 
            style="z-index: 1; left: 27px; top: 875px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="txtDocDescr2" runat="server" Width="480px" TabIndex="4" 
            BackColor="White" 
            style="z-index: 1; left: 187px; top: 819px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDockDate5" runat="server" TabIndex="9" BackColor="White" 
            style="z-index: 1; left: 25px; top: 903px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDocDescr5" runat="server" Width="480px" TabIndex="10" 
            BackColor="White" 
            style="z-index: 1; left: 186px; top: 902px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtComments" runat="server" Height="178px" Width="610px" 
            TextMode="MultiLine" TabIndex="11" 
            style="z-index: 1; left: 25px; top: 972px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDockDesc0" runat="server" BackColor="White"
            Font-Bold="False" Font-Size="Small" ForeColor="Black" 
            Text="DOCKET DESCRIPTION" 
            
            style="z-index: 1; left: 213px; top: 766px; position: absolute; width: 404px; height: 19px"></asp:Label>

        <asp:TextBox ID="txtDocDescr1" runat="server" Width="480px" TabIndex="2" 
            BackColor="White" 
            style="z-index: 1; left: 186px; top: 795px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDocDescr4" runat="server" Width="480px" TabIndex="8" 
            BackColor="White" 
            style="z-index: 1; left: 188px; top: 873px; position: absolute"></asp:TextBox>

        <asp:Button ID="btnClear" runat="server" 
            style="z-index: 1; left: 261px; top: 1196px; position: absolute; height: 27px; width: 129px" 
            Text="CLEAR" Font-Bold="True" ForeColor="Navy" Visible="False" />
        <asp:Button ID="btSearchScreen" runat="server" 
            style="z-index: 1; left: 417px; top: 1196px; position: absolute; width: 207px; height: 26px;" 
            Text="SEARCH SCREEN" Font-Bold="True" ForeColor="Navy" 
            PostBackUrl="~/SearchForm/SearchForm.aspx" 
            ToolTip="Come Back To Search Screen" />
        <asp:Button ID="btnUpdate" runat="server" Font-Bold="True" ForeColor="#3333CC" 
            style="z-index: 1; left: 109px; top: 1195px; position: absolute; width: 112px" 
            Text="UPDATE" TabIndex="12" />
   



</td>
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
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
