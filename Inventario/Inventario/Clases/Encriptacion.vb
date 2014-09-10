Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class Encriptacion

    Private MD5 As MD5CryptoServiceProvider
    Private DES As TripleDESCryptoServiceProvider

    'Clave para desencriptar y encriptar necesaria.
    Private key As String = "mikedosce"

    Public Sub New(key As String)
        MD5 = New MD5CryptoServiceProvider()
        DES = New TripleDESCryptoServiceProvider()
        DES.Key = MD5Hash(key)
        DES.Mode = CipherMode.ECB
    End Sub

    Private Function MD5Hash(valor As String) As Byte()

        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(valor))
    End Function

    Public Function Encriptar(valor As String) As String
        Dim buffer() As Byte = ASCIIEncoding.ASCII.GetBytes(valor)

        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

    Public Function Desencriptar(valor As String) As String
        Dim buffer() As Byte = Convert.FromBase64String(valor)

        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

End Class
