'*************************************************************************************************
' Application   :   MCAWARRANT
' Author        :   Irina Gindina
' Date          :   03/12/2013
' Comments      :   Inteface for Error Login Class. Insert Data base Errors into MCAWARRANT.MCAErrorsLog table
'***********************************************************************************************************
' Revision History: 
'*********************************************************************************************************************
Public Interface IErrorLog

    Function LogException(
                        ByVal PageUrl As String, _
                        ByVal MessageDesc As String, _
                        ByVal ServerName As String, _
                        ByVal user_name As String) As String
End Interface
