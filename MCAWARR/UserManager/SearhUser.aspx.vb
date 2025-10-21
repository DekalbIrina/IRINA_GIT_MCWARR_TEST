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
Public Class SearhUser
    Inherits System.Web.UI.Page
    Dim sUserAddedBy As String
    Dim ErrorLogObject As New ErrorLog

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not IsPostBack Then
            LoadUserGrid()
        End If
    End Sub
    Public Sub LoadUserGrid()

        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try

            Dim tbl_mcawarr As New Data.DataTable
            Dim find_mcawarr As SqlCommand = New SqlCommand("Select_UserInformation", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@userID", 0)

            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Dim adap As SqlDataAdapter = New SqlDataAdapter(find_mcawarr)
            adap.Fill(tbl_mcawarr)


            Me.grdsearch.DataSource = tbl_mcawarr

            Me.DataBind()

            If tbl_mcawarr.Rows.Count > 0 Then
                Me.lblInfoMessage.Visible = True
                Me.lblInfoMessage.Text = tbl_mcawarr.Rows.Count & "  " & "Records Found."
            Else
                Me.lblErrorMessage.Visible = True
                Me.lblErrorMessage.Text = "There is no Users exist in MCAWARRANT."
            End If

        Catch ex As Exception
            ex.Message.ToString()
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("SearchUser.aspx.vb", Me.lblErrorMessage.Text, "", sUserAddedBy)
        End Try
        mcawarrconnection.Close()

    End Sub



    Protected Sub grdsearch_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grdsearch.RowCommand
        'Get USerID from Grid and assign to Session Variable
        If e.CommandName = "Select" Then

            ' Convert the row index stored in the CommandArgument
            ' property to an Integer.
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)

            ' Get the UserLoginName of from the appropriate
            ' cell in the GridView control to pass it to Update User Screen.
            Dim selectedRow As GridViewRow = grdsearch.Rows(index)
            Dim contactCell As TableCell = selectedRow.Cells(1)
            Dim UserIDKey As Integer = contactCell.Text

            Session("UserID") = UserIDKey
        End If
    End Sub

    Protected Sub grdsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grdsearch.SelectedIndexChanged
        'Redirect Program to Update USer Screen
        Response.Redirect("~/UserManager/UpdateUser.aspx")
    End Sub


    Protected Sub grdsearch_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles grdsearch.PageIndexChanging
        'Take care about Paging, when user click on different page number grid has been relaod
        Me.grdsearch.PageIndex = e.NewPageIndex
        LoadUserGrid()
    End Sub
End Class