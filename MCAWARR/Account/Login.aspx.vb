Imports System.Data
Imports System.Object
Imports System.Web.Configuration.WebConfigurationManager
Imports System.Data.SqlClient
Imports System.Web

Public Class Login
    Inherits System.Web.UI.Page
    '*************************************************************************************************
    ' Application   :   MCAWARRANT
    ' Author        :   Irina Gindina
    ' Date          :   03/01/2013
    ' Comments      :   Provide error message if User validated by Active Directory but does not exist in MCAWarrant program
    '***********************************************************************************************************
    ' Revision History: 
    '*********************************************************************************************************************
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
   
        Me.lblLoginErrorMessage.Visible = False

        If Not Page.IsPostBack Then
            'Validation result come back from Site.aspx.vb page 
            If Session("UserName") <> "" Then
                'User does not exist in MCAUser table, program gives error message
                If Session("UserAuthenticated") = False Then
                    Me.lblLoginErrorMessage.Visible = True
                    Me.lblLoginErrorMessage.Text = "You are not authorized to view this application, Contact your supervisor for further details."
                    'SEt up Session Authorization to TRUE,  otherwise it will be loop in Site.aspx.vb. 
                    'When user does not exsit in MCAUser Table program was not able to get out from loop, thats why I added UserAuthentication here. 
                    Session("UserAuthenticated") = True
                Else
                    Me.lblLoginErrorMessage.Visible = False
                End If
                'If Data Base error occures on Default.aspx.vb page program redirected to Login and gives this message
                If Session("DataBaseError") Then
                    Me.lblDBError.Visible = True
                    Me.lblDBError.Text = "Data Base Error. Contact IT Departmetn'"
                End If
            End If
        End If
    End Sub


End Class