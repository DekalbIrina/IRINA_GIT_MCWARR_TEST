Imports System.Data
Imports System.Object
Imports System.Web.Configuration.WebConfigurationManager
Imports System.Data.SqlClient
Public Class WarrantViewUpdate
    Inherits System.Web.UI.Page
    Dim ErrorLogObject As New ErrorLog

    '*************************************************************************************************
    ' Application   :   MCAWARRANT
    ' Author        :   Irina Gindina
    ' Date          :   03/18/2013
    ' Comments      :   Show Warrant Information. Allow update Docket date and Docket Description fields on the screen for ADMIN only. 
    '***********************************************************************************************************
    ' Revision History: 
    '*********************************************************************************************************************

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim sRoleID As Integer

        sRoleID = Session("LoggedEmployeeRoleId")

        'Allow update record only ADMIN role
        If sRoleID = 1 Then
            Me.btnUpdate.Visible = True
            Me.btnClear.Visible = True
        Else
            'Configure fields for USER
            Me.btnUpdate.Visible = False
            Me.btnClear.Visible = False


            'Docket Date 1
            Me.txtDockDate1.ReadOnly = True
            Me.txtDockDate1.ForeColor = Drawing.Color.Blue
            Me.txtDockDate1.Font.Bold = True
            Me.txtDockDate1.BorderWidth = 0

            'Docket Description 1
            Me.txtDocDescr1.ReadOnly = True
            Me.txtDocDescr1.ForeColor = Drawing.Color.Blue
            Me.txtDocDescr1.Font.Bold = True
            Me.txtDocDescr1.BorderWidth = 0



            'Docket Date 2
            Me.txtDockDate2.ReadOnly = True
            Me.txtDockDate2.ForeColor = Drawing.Color.Blue
            Me.txtDockDate2.Font.Bold = True
            Me.txtDockDate2.BorderWidth = 0

            'Docket Description 2
            Me.txtDocDescr2.ReadOnly = True
            Me.txtDocDescr2.ForeColor = Drawing.Color.Blue
            Me.txtDocDescr2.Font.Bold = True
            Me.txtDocDescr2.BorderWidth = 0


            'Docket Date 3
            Me.txtDockDate3.ReadOnly = True
            Me.txtDockDate3.ForeColor = Drawing.Color.Blue
            Me.txtDockDate3.Font.Bold = True
            Me.txtDockDate3.BorderWidth = 0

            'Docket Description 3
            Me.txtDocDescr3.ReadOnly = True
            Me.txtDocDescr3.ForeColor = Drawing.Color.Blue
            Me.txtDocDescr3.Font.Bold = True
            Me.txtDocDescr3.BorderWidth = 0

            'Docket Date 4
            Me.txtDockDate4.ReadOnly = True
            Me.txtDockDate4.ForeColor = Drawing.Color.Blue
            Me.txtDockDate4.Font.Bold = True
            Me.txtDockDate4.BorderWidth = 0

            'Docket Description 4
            Me.txtDocDescr4.ReadOnly = True
            Me.txtDocDescr4.ForeColor = Drawing.Color.Blue
            Me.txtDocDescr4.Font.Bold = True
            Me.txtDocDescr4.BorderWidth = 0



            'Docket Date 5
            Me.txtDockDate5.ReadOnly = True
            Me.txtDockDate5.ForeColor = Drawing.Color.Blue
            Me.txtDockDate5.Font.Bold = True
            Me.txtDockDate5.BorderWidth = 0

            'Docket Description 5
            Me.txtDocDescr5.ReadOnly = True
            Me.txtDocDescr5.ForeColor = Drawing.Color.Blue
            Me.txtDocDescr5.Font.Bold = True
            Me.txtDocDescr5.BorderWidth = 0


            'Comment Field
            Me.txtComments.ReadOnly = True
            Me.txtComments.ForeColor = Drawing.Color.Blue
            Me.txtComments.Font.Bold = True
            Me.txtComments.BorderWidth = 0

        End If

        Me.lblErrorMessage.Visible = False
        'Place cursor on first updatable field
        Me.txtDockDate1.Focus()

        If Not IsPostBack Then
            'Load Page Informaiton
            Call SelectWarrantDetail()
        End If


    End Sub

    Private Sub SelectWarrantDetail()
        'Populated Warrant Details Sreen based on Warrant ID 
        Dim WarrantID As Integer
        WarrantID = Session("warrant_id")

        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try



            Dim tbl_mcawarr As New Data.DataTable
            Dim find_mcawarr As SqlCommand = New SqlCommand("Select_WarrantDetails", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@warrant_id", WarrantID)

            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Dim adap As SqlDataAdapter = New SqlDataAdapter(find_mcawarr)
            adap.Fill(tbl_mcawarr)

            'Assign value to text box. Use ToString() function to convert DBNull to empty value
            Me.txtWarrantNum.Text = tbl_mcawarr.Rows(0)("WARRANT NUMBER")
            Me.txtApplDate.Text = tbl_mcawarr.Rows(0)("APPLICATION DATE")
            Me.txtDefFirst.Text = tbl_mcawarr.Rows(0)("DEFENDANT FIRST NAME").ToString()
            Me.txtDefLast.Text = tbl_mcawarr.Rows(0)("DEFENDANT LAST NAME").ToString()
            Me.txtDefMiddle.Text = tbl_mcawarr.Rows(0)("DEFENDANT MIDDLE NAME").ToString()
            'Me.txtDefName.Text = tbl_mcawarr.Rows(0)("DEFENDANT LAST NAME") & "  " & tbl_mcawarr.Rows(0)("DEFENDANT FIRST NAME") & "  " & tbl_mcawarr.Rows(0)("DEFENDANT MIDDLE NAME")

            Me.txtDeffAddress.Text = tbl_mcawarr.Rows(0)("DEFENDANT ADDRESS") & "  " & tbl_mcawarr.Rows(0)("DEFENDANT APT") & "  " & tbl_mcawarr.Rows(0)("DEFENDANT CITY") & "  " & tbl_mcawarr.Rows(0)("DEFENDANT STATE") & "  " & tbl_mcawarr.Rows(0)("DEFENDANT ZIP CODE 1") & "  " & tbl_mcawarr.Rows(0)("DEFENDANT ZIP CODE 2")

            Me.txtPlainFirstName.Text = tbl_mcawarr.Rows(0)("PLAINTIFF FIRST NAME").ToString()
            Me.txtPlainLastName.Text = tbl_mcawarr.Rows(0)("PLAINTIFF LAST NAME").ToString()
            Me.txtPlainMiddleName.Text = tbl_mcawarr.Rows(0)("DEFENDANT MIDDLE NAME").ToString()
            'Me.txtPlainName.Text = tbl_mcawarr.Rows(0)("PLAINTIFF LAST NAME") & " " & tbl_mcawarr.Rows(0)("PLAINTIFF FIRST NAME") & " " & tbl_mcawarr.Rows(0)("PLAINTIFF MIDDLE NAME")

            Me.txtPlaintAddress.Text = tbl_mcawarr.Rows(0)("PLAINTIFF ADDRESS") & "  " & tbl_mcawarr.Rows(0)("PLANTIFF APT") & "  " & tbl_mcawarr.Rows(0)("PLAINTIFF CITY") & "  " & tbl_mcawarr.Rows(0)("PLAINTIFF STATE") & "  " & tbl_mcawarr.Rows(0)("PLAINTIFF ZIP CODE 1") & "  " & tbl_mcawarr.Rows(0)("PLAINTIFF ZIP CODE 2")

            Dim PhoneNumber As String
            PhoneNumber = "(" & tbl_mcawarr.Rows(0)("AREA CODE").ToString() & ")" & tbl_mcawarr.Rows(0)("WARRANT PHONE NUMBER1").ToString() & "-" & tbl_mcawarr.Rows(0)("WARRANT PHONE NUMBER2").ToString()

            Me.txtWarrantPhone1.Text = PhoneNumber
            Me.txtWarrantAmt.Text = tbl_mcawarr.Rows(0)("WARRANT AMOUNT").ToString()
            Me.txtWarrantDate.Text = tbl_mcawarr.Rows(0)("WARRANT DATE").ToString()
            Me.txtWarrJudgeName.Text = tbl_mcawarr.Rows(0)("WARRANT JUDGE NAME").ToString()
            Me.txtWarrantLocation.Text = tbl_mcawarr.Rows(0)("WARRANT LOCATION").ToString()
            Me.txtWarrDisposition.Text = tbl_mcawarr.Rows(0)("WARRANT DISPOSITION").ToString()
            Me.txtWarrantCharge.Text = tbl_mcawarr.Rows(0)("WARRANT CHARGE").ToString()
            Me.txtOffenceCharge.Text = tbl_mcawarr.Rows(0)("OFFENCE CHARGE").ToString()
            Me.txtappJudgeName.Text = tbl_mcawarr.Rows(0)("APPLICATION JUDGE NAME").ToString()
            Me.txtApplAmt.Text = tbl_mcawarr.Rows(0)("APPLICATION AMOUNT").ToString()
            Me.txtDismisDate.Text = tbl_mcawarr.Rows(0)("DISMISSAL DATE").ToString()
            Me.txtDismisAmt.Text = tbl_mcawarr.Rows(0)("DISMISSAL AMOUNT").ToString()
            Me.txtDockDate1.Text = tbl_mcawarr.Rows(0)("DOCKET DATE 1").ToString()
            Me.txtDocDescr1.Text = tbl_mcawarr.Rows(0)("DOCKET DESCRIPTION  1").ToString()
            Me.txtDockDate2.Text = tbl_mcawarr.Rows(0)("DOCKET DATE 2").ToString()
            Me.txtDocDescr2.Text = tbl_mcawarr.Rows(0)("DOCKET DESCRIPTION  2").ToString()
            Me.txtDockDate3.Text = tbl_mcawarr.Rows(0)("DOCKET DATE 3").ToString()
            Me.txtDocDescr3.Text = tbl_mcawarr.Rows(0)("DOCKET DESCRIPTION  3").ToString()
            Me.txtDockDate4.Text = tbl_mcawarr.Rows(0)("DOCKET DATE 4").ToString()
            Me.txtDocDescr4.Text = tbl_mcawarr.Rows(0)("DOCKET DESCRIPTION  4").ToString()
            Me.txtDockDate5.Text = tbl_mcawarr.Rows(0)("DOCKET DATE 5").ToString()
            Me.txtDocDescr5.Text = tbl_mcawarr.Rows(0)("DOCKET DESCRIPTION  5").ToString()
            Me.txtComments.Text = tbl_mcawarr.Rows(0)("COMMENTS").ToString()


        Catch ex As Exception
            ex.Message.ToString()
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("WarrantDetails.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
        End Try
        mcawarrconnection.Close()
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Update Docket Dates, Docket Description, Comments Fied. 

        Dim WarrantID As Integer
        WarrantID = Session("warrant_id")

        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try

            Dim find_mcawarr As SqlCommand = New SqlCommand("Update_WarrantDetails", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@warrant_id", WarrantID)
            find_mcawarr.Parameters.AddWithValue("@docketDescr1", txtDocDescr1.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDate1", txtDockDate1.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDescr2", txtDocDescr2.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDate2", txtDockDate2.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDescr3", txtDocDescr3.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDate3", txtDockDate3.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDescr4", txtDocDescr4.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDate4", txtDockDate4.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDescr5", txtDocDescr5.Text)
            find_mcawarr.Parameters.AddWithValue("@docketDate5", txtDockDate5.Text)
            find_mcawarr.Parameters.AddWithValue("@comments", txtComments.Text)
            find_mcawarr.Parameters.AddWithValue("@updatedBy", Session("UserName"))


            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Me.lblUpdateSucess.Visible = True
            Me.lblUpdateSucess.Text = "RECORD HAS BEEN UPDATED."



        Catch ex As Exception
            ex.Message.ToString()
            Me.lblUpdateSucess.Visible = False
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("WarrantDetails.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
        End Try
        mcawarrconnection.Close()

    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Me.txtDockDate1.Text = ""
        Me.txtDocDescr1.Text = ""
        Me.txtDockDate2.Text = ""
        Me.txtDocDescr2.Text = ""
        Me.txtDockDate3.Text = ""
        Me.txtDocDescr3.Text = ""
        Me.txtDockDate4.Text = ""
        Me.txtDocDescr4.Text = ""
        Me.txtDockDate5.Text = ""
        Me.txtDocDescr5.Text = ""
        Me.txtComments.Text = ""

    End Sub
End Class