Imports System.Data
Imports System.Object
Imports System.Web.Configuration.WebConfigurationManager
Imports System.Data.SqlClient
Public Class _Default
    Inherits System.Web.UI.Page
    '*************************************************************************************************
    ' Application   :   MCAWARRANT
    ' Author        :   Irina Gindina
    ' Date          :   02/25/2013
    ' Comments      :   This is Start page of Application. Its also gets User Information from Data base
    '***********************************************************************************************************
    ' Revision History: 
    '*********************************************************************************************************************
    Dim ErrorLogObject As New ErrorLog

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'After user click LOGIN button get information from DB if User exists and USer Role ID.
        Dim txtUserName As String

        If Not IsPostBack Then

            'Get User name from Login Box and assign to Session Variable 
            txtUserName = User.Identity.Name
            Session("UserName") = txtUserName


            If txtUserName <> "" Then
                'Get information from DB about USer Role ID and assign to Sesseion variable
                Dim sconnection As String
                sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

                Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
                mcawarrconnection.Open()
                Try
                    'Dim UserRoleID As Integer
                    Dim tbl_mcawarr As New Data.DataTable
                    Dim find_mcawarr As SqlCommand = New SqlCommand("Validate_UserLoginName", mcawarrconnection)
                    find_mcawarr.Parameters.AddWithValue("@userName", txtUserName)

                    find_mcawarr.CommandType = Data.CommandType.StoredProcedure
                    find_mcawarr.ExecuteNonQuery().ToString()

                    Dim adap As SqlDataAdapter = New SqlDataAdapter(find_mcawarr)
                    adap.Fill(tbl_mcawarr)

                    'User does exist in Active Directory and exist in MCAWarrant program (MCAUser table). 
                    If tbl_mcawarr.Rows.Count > 0 Then
                        'Assign User Role id to Session Variable
                        Session("LoggedEmployeeRoleId") = (tbl_mcawarr.Rows(0)("Role_id"))                        
                        Session("UserAuthenticated") = True

                    Else
                        'User does exist in Active Directory but DOES NOT exist in MCAUser table. User do not allow to login in program. Should be added to MCAWarrant program by Admin. 
                        Session("LoggedEmployeeRoleId") = 666
                        Session("UserAuthenticated") = False
                    End If

                Catch ex As Exception
                    ex.Message.ToString()
                    Me.lblErrorMessage.Visible = True
                    Me.lblErrorMessage.Text = ex.Message.ToString()
                    ErrorLogObject.LogException("Default.aspx.vb", Me.lblErrorMessage.Text, "", Session("UserName"))
                    'Set up session variable and redirect error to Login.aspx page to not allow user go further in program. 
                    Session("DataBaseError") = True
                    Response.RedirectPermanent("~/Account/Login.aspx")
                End Try
                mcawarrconnection.Close()

            End If
        End If

    End Sub

End Class