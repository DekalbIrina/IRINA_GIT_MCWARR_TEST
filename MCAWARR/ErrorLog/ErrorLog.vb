Public Class ErrorLog
    Implements IErrorLog
    '*************************************************************************************************
    ' Application   :   MCAWARRANT
    ' Author        :   Irina Gindina
    ' Date          :   03/12/2013
    ' Comments      :   Error Login Class. LogExeption Function calls ErrorLogDatea Access class to insert Data base Errors into MCAWARRANT.MCAErrorsLog table
    '***********************************************************************************************************
    ' Revision History: 
    '*********************************************************************************************************************
    Public Function LogException(
                    ByVal PageUrl As String, _
                    ByVal MessageDesc As String, _
                    ByVal ServerName As String, _
                    ByVal user_name As String) As String _
                    Implements IErrorLog.LogException
        Return ErrorLogDataAccess.LogExceptionToDB(PageUrl, MessageDesc, ServerName, user_name)
    End Function
End Class
