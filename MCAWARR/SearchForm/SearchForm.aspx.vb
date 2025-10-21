Imports System.Data
Imports System.Object
Imports System.Web.Configuration.WebConfigurationManager
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
'*************************************************************************************************
' Application   :   MCAWARRANT
' Author        :   Irina Gindina
' Date          :   03/12/2013
' Comments      :   Search for records using different Search criteria. If DB errors ocures check MCAErrorsLog table MCAWarrant DB
'***********************************************************************************************************
' Revision History: 
'*********************************************************************************************************************
Public Class SearchForm
    Inherits System.Web.UI.Page
    Dim ErrorLogObject As New ErrorLog


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

 
    Protected Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click



        Try
            Select Case Me.RadioButtonList1.SelectedIndex

                Case 0

                    'Search by Defendant First and Last Name         
                    If Me.txtFirstName.Text = "" And Me.txtLastName.Text = "" Then
                        Me.lblErrorMessage.Visible = True
                        Me.lblErrorMessage.Text = "Please enter First name or Last Name and click Submit Button."
                    Else
                        Me.lblErrorMessage.Visible = False
                        Call GetDeffGridResult()
                    End If


                Case 1
                    'Search by Plaintiff First and Last Name

                    If Me.txtFirstName.Text = "" And Me.txtLastName.Text = "" Then
                        Me.lblErrorMessage.Visible = True
                        Me.lblErrorMessage.Text = "Please enter First name or Last Name and click Submit Button."
                    Else
                        Me.lblErrorMessage.Visible = False
                        Call GetDPlaintiffGridResult()
                    End If



                Case 2
                    'Search by warrant Number

                    If Me.txtWarrantNumber.Text = "" Then
                        Me.lblErrorMessage.Visible = True
                        Me.lblErrorMessage.Text = "Please enter Warrant Number and click Submit Button."
                    Else
                        Me.lblErrorMessage.Visible = False
                        Call GetWarrantNumGridResult()
                    End If
            End Select

        Catch ex As Exception
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("SearchForm.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))

        End Try

    End Sub

    Public Sub GetDeffGridResult()
        'Search Records for Defendant First and Last name
        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try
            Dim sDefendantFirstName As String
            Dim sDefendantLastName As String



            sDefendantFirstName = Me.txtFirstName.Text
            sDefendantLastName = Me.txtLastName.Text

            Dim tbl_mcawarr As New Data.DataTable
            Dim find_mcawarr As SqlCommand = New SqlCommand("Sel_ByDEFENDANTFirstAndLastName", mcawarrconnection)

            find_mcawarr.Parameters.AddWithValue("@FirstName", sDefendantFirstName)
            find_mcawarr.Parameters.AddWithValue("@LastName", sDefendantLastName)

            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Dim adap As SqlDataAdapter = New SqlDataAdapter(find_mcawarr)
            adap.Fill(tbl_mcawarr)


            Me.grdsearch.Visible = True

            Me.grdsearch.DataSource = tbl_mcawarr



            Me.DataBind()


            'Assign Number of Records to label. For some reason I have to set up visible for grid to False if number of record 0 to show Info label in the right position.
            If tbl_mcawarr.Rows.Count > 0 Then
                Me.lblInfoMessage.Visible = True
                Me.lblInfoMessage.Text = tbl_mcawarr.Rows.Count & "  " & "Records Found."
            Else
                Me.grdsearch.Visible = False
                Me.lblInfoMessage.Visible = True
                Me.lblInfoMessage.Text = tbl_mcawarr.Rows.Count & "  " & "Records Found."
            End If

        Catch ex As Exception
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("SearchForm.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
        End Try
        mcawarrconnection.Close()

    End Sub
    Public Sub GetDPlaintiffGridResult()
        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try

            Dim sPlaintifFirstName As String
            Dim sPlaintifLastName As String


            sPlaintifFirstName = Me.txtFirstName.Text
            sPlaintifLastName = Me.txtLastName.Text

            Dim tbl_mcawarr As New Data.DataTable
            Dim find_mcawarr As SqlCommand = New SqlCommand("Sel_ByPLAINTIFFirstAndLastName", mcawarrconnection)

            find_mcawarr.Parameters.AddWithValue("@FirstName", sPlaintifFirstName)
            find_mcawarr.Parameters.AddWithValue("@LastName", sPlaintifLastName)

            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Dim adap As SqlDataAdapter = New SqlDataAdapter(find_mcawarr)
            adap.Fill(tbl_mcawarr)

            Me.grdsearch.Visible = True
            Me.grdsearch.DataSource = tbl_mcawarr



            Me.DataBind()
            'Assign Number of Records to label. For some reason I have to set up visible for grid to False if number of record 0 to show Info label in the right position.
            If tbl_mcawarr.Rows.Count > 0 Then
                Me.lblInfoMessage.Visible = True
                Me.lblInfoMessage.Text = tbl_mcawarr.Rows.Count & "  " & "Records Found."
            Else
                Me.grdsearch.Visible = False
                Me.lblInfoMessage.Visible = True
                Me.lblInfoMessage.Text = tbl_mcawarr.Rows.Count & "  " & "Records Found."
            End If

        Catch ex As Exception
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("SearchForm.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
        End Try
        mcawarrconnection.Close()


    End Sub
    Public Sub GetWarrantNumGridResult()
        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try

            Dim sWarrantNumber As String


            sWarrantNumber = Me.txtWarrantNumber.Text


            Dim tbl_mcawarr As New Data.DataTable
            Dim find_mcawarr As SqlCommand = New SqlCommand("Sel_ByWarrantNumber", mcawarrconnection)

            find_mcawarr.Parameters.AddWithValue("@WarrantNumber", sWarrantNumber)


            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Dim adap As SqlDataAdapter = New SqlDataAdapter(find_mcawarr)
            adap.Fill(tbl_mcawarr)

            Me.grdsearch.Visible = True
            Me.grdsearch.DataSource = tbl_mcawarr

            Me.DataBind()

            'Assign Number of Records to label. For some reason I have to set up visible for grid to False if number of record 0 to show Info label in the right position.
            If tbl_mcawarr.Rows.Count > 0 Then
                Me.lblInfoMessage.Visible = True
                Me.lblInfoMessage.Text = tbl_mcawarr.Rows.Count & "  " & "Records Found."
            Else
                Me.grdsearch.Visible = False
                Me.lblInfoMessage.Visible = True
                Me.lblInfoMessage.Text = tbl_mcawarr.Rows.Count & "  " & "Records Found."
            End If

        Catch ex As Exception
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("SearchForm.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
        End Try
        mcawarrconnection.Close()

    End Sub

    Protected Sub grdsearch_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles grdsearch.PageIndexChanging
        'Call different Grid fill out functions for different Seraching Options. This take care about paging as well. When user gets different Grid result Page will set up to 1. 

        Me.grdsearch.PageIndex = e.NewPageIndex

        Select Case Me.RadioButtonList1.SelectedIndex
            Case 0
                'Search by Defendant First and Last Name
                Call GetDeffGridResult()
            Case 1
                'Search by Plaintiff First and Last name
                Call GetDPlaintiffGridResult()
            Case 2
                'Search by Warrant Number
                Call GetWarrantNumGridResult()

        End Select
    End Sub

    Protected Sub grdsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grdsearch.SelectedIndexChanged
        Response.Redirect("~/UpdateForm/WarrantDetails.aspx")
    End Sub

    Protected Sub grdsearch_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grdsearch.RowCommand

        'Get Warrant ID value to store into Session variable
        If e.CommandName = "Select" Then

            ' Convert the row index stored in the CommandArgument
            ' property to an Integer.
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)

            ' Get the warrant_id of from the appropriate
            ' cell in the GridView control to pass it to WarrantDetails Screen.
            Dim selectedRow As GridViewRow = grdsearch.Rows(index)
            Dim contactCell As TableCell = selectedRow.Cells(1)
            Dim warrantkey As String = contactCell.Text

            Session("warrant_id") = warrantkey

        End If
    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        Try

            Select Case Me.RadioButtonList1.SelectedIndex

                Case 0
                    'Search by Defendant First and Last Name
                    Me.lblfirst.Visible = True
                    Me.lbllast.Visible = True

                    Me.txtFirstName.Visible = True
                    Me.txtLastName.Visible = True
                    Me.txtWarrantNumber.Visible = False
                    Me.txtFirstName.Text = ""
                    Me.txtLastName.Text = ""
                    Me.txtWarrantNumber.Text = ""
                 
                    Me.lblWarrantNumber.Visible = False
                    Me.txtWarrantNumber.Visible = False
                    Me.lblErrorMessage.Visible = False
                    Me.lblInfoMessage.Visible = False

                    'Clear Grid View
                    Me.grdsearch.Visible = False
                    Me.grdsearch.PageIndex = 0

                    'Place Curson on First Name text box
                    Me.txtFirstName.Focus()

                Case 1
                    'Serach by Plaintiff 
                    Me.lblfirst.Visible = True
                    Me.lbllast.Visible = True

                    Me.txtFirstName.Visible = True
                    Me.txtLastName.Visible = True
                    Me.txtWarrantNumber.Visible = False
                    Me.txtFirstName.Text = ""
                    Me.txtLastName.Text = ""
                    Me.txtWarrantNumber.Text = ""

                    Me.lblWarrantNumber.Visible = False
                    Me.txtWarrantNumber.Visible = False
                    Me.lblErrorMessage.Visible = False
                    Me.lblInfoMessage.Visible = False

                    'Clear Grid View
                    Me.grdsearch.Visible = False
                    Me.grdsearch.PageIndex = 0

                    'Place Curson on First Name text box
                    Me.txtFirstName.Focus()
                Case 2
                    'Search by warrant Number 
                    Me.lblfirst.Visible = False
                    Me.lbllast.Visible = False
                    Me.txtFirstName.Visible = False
                    Me.txtLastName.Visible = False
                    Me.txtFirstName.Text = ""
                    Me.txtLastName.Text = ""
                    Me.txtWarrantNumber.Text = ""

                    Me.lblWarrantNumber.Visible = True
                    Me.txtWarrantNumber.Visible = True
                    Me.lblErrorMessage.Visible = False
                    Me.lblInfoMessage.Visible = False

                    'Clear Grid View
                    Me.grdsearch.Visible = False
                    Me.grdsearch.PageIndex = 0

                    'Plase curson on Warrant Number text box
                    Me.txtWarrantNumber.Focus()

            End Select



        Catch ex As Exception
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("SearchForm.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
        End Try

    End Sub

    Protected Sub grdsearch_RowCreated(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdsearch.RowCreated
        'e.Row.Cells(0).Visible = False <--THis Hiding Column Warrant_ID on the header of the greed.
        If (e.Row.RowType = DataControlRowType.DataRow Or e.Row.RowType = DataControlRowType.Header) Then

            e.Row.Cells(1).Visible = False

        End If
    End Sub

    Protected Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click

        Me.txtFirstName.Text = ""
        Me.txtLastName.Text = ""
        Me.txtWarrantNumber.Text = ""

        Me.lblInfoMessage.Visible = False
        Me.lblErrorMessage.Visible = False

        'Clear Grid View
        Me.grdsearch.Visible = False
        Me.grdsearch.PageIndex = 0

    End Sub
End Class