Imports System.Data
Imports System.Object
Imports System.Web.Configuration.WebConfigurationManager
Imports System.Data.SqlClient

'*************************************************************************************************
' Application   :   MCAWARRANT
' Author        :   Irina Gindina
' Date          :   04/10/2013
' Comments      :   Add New user to program by inserting New record in MCAUser table. Validate value of UserLoginName, it should be unique
'***********************************************************************************************************
' Revision History: 
'*********************************************************************************************************************
Public Class AddNewUser
    Inherits System.Web.UI.Page
    Dim sUserAddedBy As String
    Dim ErrorLogObject As New ErrorLog


    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Avoid focus on browser address bar or some additional toolbar
        'tab key ASCII code is 9
        Me.btnAddNewUser.Attributes.Add("onkeydown", _
        "if(event.which || event.keyCode)" & _
        "{if ((event.which == 9) || (event.keyCode == 9)) " & _
        "{document.getElementById('" & Me.txtUserFirstName.ClientID & _
        "').focus();return false;}} else {return true}; ")


        sUserAddedBy = Session("UserName")

        If Not IsPostBack Then
            Me.txtAddedBy.Text = sUserAddedBy
            Me.txtAddDate.Text = Date.Today

            'Place cursor on this text box
            Me.txtUserFirstName.Focus()
        End If


    End Sub

    Protected Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click
        Dim LoginNameIsUnique As Boolean
        'Validate UserLoginName value. This value should be Unique
        LoginNameIsUnique = ValidateUserLoginName()

        If LoginNameIsUnique = True Then
            'UserLoginName is unique, update infor in DB           
            AddNewUser()
        Else
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = "User Login Name" & " " & Me.txtUserLoginName.Text.ToUpper & " " & " exists in MCAWARRANT application. Please enter different User Login Name."
        End If
    End Sub

    Public Function ValidateUserLoginName() As Boolean

        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try

            Dim tbl_mcawarr As New Data.DataTable
            Dim find_mcawarr As SqlCommand = New SqlCommand("Validate_UserLoginName", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@userName", txtUserLoginName.Text)

            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Dim adap As SqlDataAdapter = New SqlDataAdapter(find_mcawarr)
            adap.Fill(tbl_mcawarr)

            'Validate User Login Name for Unique value 
            If tbl_mcawarr.Rows.Count > 0 Then
                'UserLoginName is not unique
                Return False
            Else
                'UserLoginName is Unique, proceed with update
                Return True
            End If

        Catch ex As Exception
            ex.Message.ToString()
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("AddNewUser.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
        End Try
        mcawarrconnection.Close()
    End Function
    Public Sub AddNewUser()

        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try

            Dim find_mcawarr As SqlCommand = New SqlCommand("Insert_MCAUserInformation", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@Firstname", Me.txtUserFirstName.Text)
            find_mcawarr.Parameters.AddWithValue("@Lastname", Me.txtUserLastName.Text)
            find_mcawarr.Parameters.AddWithValue("@MiddleName", Me.txtUserMidName.Text)
            find_mcawarr.Parameters.AddWithValue("@NewUserLoginName", Me.txtUserLoginName.Text)
            find_mcawarr.Parameters.AddWithValue("@Permissions", Me.ddPermission.SelectedValue.ToString)
            find_mcawarr.Parameters.AddWithValue("@JobTitle", Me.txtUserJobTitle.Text)
            find_mcawarr.Parameters.AddWithValue("@AddedBy", sUserAddedBy)
            find_mcawarr.Parameters.AddWithValue("@Comments ", txtComments.Text)


            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            'Redirect to List OF Users. To avoid exeption error "Thread was being aborted" set up second argument to FALSE
            Response.Redirect("~/UserManager/SearhUser.aspx", False)


        Catch ex As Exception
            ex.Message.ToString()
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("AddNewUser.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
        End Try
        mcawarrconnection.Close()
    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtUserFirstName.Text = ""
        Me.txtUserLastName.Text = ""
        Me.txtUserMidName.Text = ""
        Me.txtUserJobTitle.Text = ""
        Me.txtUserLoginName.Text = ""
        Me.txtComments.Text = ""

        Me.lblErrorMessage.Visible = False

    End Sub

    'Protected Sub btnBacktoUserManag_Click(sender As Object, e As EventArgs) Handles btnBacktoUserManag.Click
    '    Response.Redirect("~/UserManager/UserMenu.aspx")
    'End Sub
End Class