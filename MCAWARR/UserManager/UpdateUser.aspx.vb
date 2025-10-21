Imports System.Data
Imports System.Object
Imports System.Web.Configuration.WebConfigurationManager
Imports System.Data.SqlClient
Public Class UpdateUser
    Inherits System.Web.UI.Page
    '*************************************************************************************************
    ' Application   :   MCAWARRANT
    ' Author        :   Irina Gindina
    ' Date          :   04/04/2013
    ' Comments      :   This is Update User Page. ADMIN will be able update USer information or Delete user from System
    '***********************************************************************************************************
    ' Revision History: 
    '*********************************************************************************************************************
    Dim UserID As Integer
    Dim ErrorLogObject As New ErrorLog
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Avoid focus on browser address bar or some additional toolbar
        'tab key ASCII code is 9
        Me.btnUpdateUser.Attributes.Add("onkeydown", _
        "if(event.which || event.keyCode)" & _
        "{if ((event.which == 9) || (event.keyCode == 9)) " & _
        "{document.getElementById('" & Me.txtUserFirstName.ClientID & _
        "').focus();return false;}} else {return true}; ")


        UserID = Session("UserID")

        If Not IsPostBack Then
            'Place cursor on this text box
            Me.txtUserFirstName.Focus()

            LoadtUserInfo()
        End If

    End Sub
    Public Sub LoadtUserInfo()
        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try

            Dim tbl_mcawarr As New Data.DataTable
            Dim find_mcawarr As SqlCommand = New SqlCommand("Select_UserInformation", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@userID", UserID)

            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Dim adap As SqlDataAdapter = New SqlDataAdapter(find_mcawarr)
            adap.Fill(tbl_mcawarr)

            Dim sPermission As Integer

            If tbl_mcawarr.Rows.Count > 0 Then           
                Me.txtUserFirstName.Text = tbl_mcawarr.Rows(0)("FIRST_NAME").ToString()
                Me.txtUserLastName.Text = tbl_mcawarr.Rows(0)("Last_Name").ToString()
                Me.txtUserMidName.Text = tbl_mcawarr.Rows(0)("Middle_Name").ToString()
                Me.txtUserLoginName.Text = tbl_mcawarr.Rows(0)("UserLoginName").ToString()
                Me.txtUserJobTitle.Text = tbl_mcawarr.Rows(0)("JobTitle").ToString()
                Me.txtComments.Text = tbl_mcawarr.Rows(0)("Comments").ToString()
                Me.txtUpdateddBy.Text = tbl_mcawarr.Rows(0)("Updated_By").ToString()
                Me.txtUpdatedDate.Text = tbl_mcawarr.Rows(0)("Updated_Date").ToString()
                sPermission = tbl_mcawarr.Rows(0)("Role_ID").ToString()

            Else
                Me.lblErrorMessage.Visible = True
                Me.lblErrorMessage.Text = "There is a problem to retrieve User " & " " & " " & "Information. Pleaase contact IT Department."
            End If

            'SEt up value for Permission Drop down box
            If sPermission = 1 Then
                Me.ddPermission.SelectedValue = "ADMIN"
            ElseIf sPermission = 2 Then
                Me.ddPermission.SelectedValue = "USER"
            End If

        Catch ex As Exception
            ex.Message.ToString()
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            ErrorLogObject.LogException("UpdateUser.aspx.vb", Me.lblErrorMessage.Text, "", Me.txtUpdateddBy.Text)

        End Try
        mcawarrconnection.Close()
    End Sub


    Protected Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click

        Dim LoginNameIsUnique As Boolean
        'Validate UserLoginName value. This value should be Unique
        LoginNameIsUnique = ValidateUserLoginName()

        If LoginNameIsUnique = True Then
            'UserLoginName is unique, update infor in DB
            Me.lblErrorMessage.Visible = False
            UpdateUserInfo()
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
                'This is Duplicate UserLogin name for different USer, return Error
                If tbl_mcawarr.Rows(0)("UserID") <> UserID Then

                    Return False
                Else
                    'This is original not updated UserloginName for updated user, continue update
                    Return True
                End If
            Else
                'UserLoginName is Unique, proceed with update
                Return True
            End If

        Catch ex As Exception
            ex.Message.ToString()
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("UpdateUser.aspx.vb", Me.lblErrorMessage.Text, "", Me.txtUpdateddBy.Text)
        End Try
        mcawarrconnection.Close()
    End Function

    Public Sub UpdateUserInfo()
        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try


            Dim find_mcawarr As SqlCommand = New SqlCommand("Update_MCAUserInformation", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@userID", UserID)
            find_mcawarr.Parameters.AddWithValue("@Firstname", Me.txtUserFirstName.Text)
            find_mcawarr.Parameters.AddWithValue("@Lastname", Me.txtUserLastName.Text)
            find_mcawarr.Parameters.AddWithValue("@MiddleName", Me.txtUserMidName.Text)
            find_mcawarr.Parameters.AddWithValue("@LoginUserName", Me.txtUserLoginName.Text)
            find_mcawarr.Parameters.AddWithValue("@Permissions", Me.ddPermission.SelectedValue.ToString)
            find_mcawarr.Parameters.AddWithValue("@JobTitle", Me.txtUserJobTitle.Text)
            find_mcawarr.Parameters.AddWithValue("@UpdatedBy", Session("UserName"))
            find_mcawarr.Parameters.AddWithValue("@Comments", Me.txtComments.Text)


            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            Me.lblUpdateSucess.Visible = True
            Me.lblUpdateSucess.Text = "USER INFORMATION HAS BEEN UPDATED."


        Catch ex As Exception
            ex.Message.ToString()
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("UpdateUser.aspx.vb", Me.lblErrorMessage.Text, "", Me.txtUpdateddBy.Text)
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

        Me.lblUpdateSucess.Visible = False

        Me.lblErrorMessage.Visible = False

    End Sub

    Protected Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try
            Dim find_mcawarr As SqlCommand = New SqlCommand("[Delete_UserInformation]", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@userID", UserID)
            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()

            'Redirect to List OF Users. To avoid exeption error "Thread was being aborted" set up second argument to FALSE
            Response.Redirect("~/UserManager/SearhUser.aspx", False)

        Catch ex As Exception
            ex.Message.ToString()
            Me.lblErrorMessage.Visible = True
            Me.lblErrorMessage.Text = ex.Message.ToString()
            'Login errors in MCAErrorsLog table
            ErrorLogObject.LogException("UpdateUser.aspx.vb", Me.lblErrorMessage.Text, "", Me.txtUpdateddBy.Text)
        End Try
        mcawarrconnection.Close()
    End Sub
End Class