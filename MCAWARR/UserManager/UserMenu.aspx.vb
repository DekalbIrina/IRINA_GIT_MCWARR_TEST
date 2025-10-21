Public Class UserMenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Session("LoggedEmployeeRoleId") = 1 Then
            Me.lnkAdduser.Visible = True
            Me.lblInfo.Visible = False
        Else
            Me.lnkAdduser.Visible = False
            Me.lnkUpdateUser.Visible = False
            Me.lblInfo.Visible = True
            Me.lblInfo.Text = "You don't have an Access Rights to use User Manager Menu."
        End If

    End Sub

End Class