Imports System.Data
Imports System.Object
Imports System.Web.Configuration.WebConfigurationManager
Imports System.Data.SqlClient
Imports System.Web.UI
Imports System.Web.UI.WebControls
Public Class Site
    Inherits System.Web.UI.MasterPage

    '*************************************************************************************************
    ' Application   :   MCAWARRANT
    ' Author        :   Irina Gindina
    ' Date          :   03/01/2013
    ' Comments      :   This is Master Page (or container) of MCAWarrant appl. 
    '***********************************************************************************************************
    ' Revision History: 
    '*********************************************************************************************************************
    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'User is not exist in MCAWARRANT program (MCAUser table). Redirect User to Login page. 
        If Session("LoggedEmployeeRoleId") = 666 Then
            If Session("UserAuthenticated") = False Then
                Response.RedirectPermanent("~/Account/Login.aspx")
            End If
        End If
    End Sub

    Protected Sub LoginView1_ViewChanged(sender As Object, e As EventArgs) Handles LoginView1.ViewChanged

    End Sub

End Class