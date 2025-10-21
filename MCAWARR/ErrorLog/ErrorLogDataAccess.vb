Imports System.Data
Imports System.Data.Common
Imports System.Object
Imports System.Web.Configuration.WebConfigurationManager
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

'*************************************************************************************************
' Application   :   MCAWARRANT
' Author        :   Irina Gindina
' Date          :   03/12/2013
' Comments      :   ErrorLogDataAccess class calls Insert_ErrorLog Store Procedure to insert Data base Errors into MCAWARRANT.MCAErrorsLog table
'***********************************************************************************************************
' Revision History: 
'*********************************************************************************************************************
Public Class ErrorLogDataAccess
    Public Shared context As System.Web.HttpContext
    Public Shared session As System.Web.SessionState.HttpSessionState
    Public Shared response As System.Web.HttpResponse
    Public Shared request As System.Web.HttpRequest
    Public Shared Function LogExceptionToDB(
                        ByVal PageUrl As String, _
                        ByVal MessageDesc As String, _
                        ByVal ServerName As String, _
                        ByVal user_name As String) As String


        Dim sconnection As String
        sconnection = System.Configuration.ConfigurationManager.ConnectionStrings("connectSQLDB").ToString

        Dim mcawarrconnection As SqlConnection = New SqlConnection(sconnection)
        mcawarrconnection.Open()
        Try

            Dim sServerName As String
            If ServerName = "" Then
                context = System.Web.HttpContext.Current()
                request = context.Request
                sServerName = request.ServerVariables("HTTP_HOST")
                'sServerName = request.ServerVariables("SERVER_NAME")<--- CHECK ON SErVEr what is giving right info, HTTP_HOST OR SERVER_NAME. Use what ever varible work. IRINA
            End If

            Dim find_mcawarr As SqlCommand = New SqlCommand("Insert_ErrorLog", mcawarrconnection)
            find_mcawarr.Parameters.AddWithValue("@PageUrl", PageUrl)
            find_mcawarr.Parameters.AddWithValue("@MessageDesc", MessageDesc)
            find_mcawarr.Parameters.AddWithValue("@ServerName", sServerName)
            find_mcawarr.Parameters.AddWithValue("@user_name", user_name)
            find_mcawarr.CommandType = Data.CommandType.StoredProcedure
            find_mcawarr.ExecuteNonQuery().ToString()


        Catch ex As Exception
            ex.Message.ToString()
            'Data Base access failed and Errors will be written into Errortext file
            Dim ApplicationLocation As String = HttpContext.Current.Server.MapPath("~")

            Dim FileLocation As String = ApplicationLocation & "ErrorLog\ErrorLogMCAWARRANT.txt"
            Dim sw As New StreamWriter(FileLocation, True)

            sw.WriteLine(" ")
            sw.WriteLine(Date.Today.ToString)
            sw.WriteLine("Bellow is Reason why 'Insert_ErrorLog' has been failed: ")
            sw.WriteLine(ex.Message.ToString())

            sw.WriteLine("Bellow is Data Base error what should be inserted into MCAErrorLog Table/MCAWARRANT Data Base:")
            Dim DBError As String = "File Name - " & " " & PageUrl & " " & "Error Description - " & " " & MessageDesc & " " & request.ServerVariables("HTTP_HOST") & " " & user_name
            sw.WriteLine(DBError)
            sw.WriteLine("___________________________________________________________________________")

            sw.Flush()
            sw.Close()

        End Try
        mcawarrconnection.Close()
    End Function
End Class
