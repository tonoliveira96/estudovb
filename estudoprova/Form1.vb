Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formcadastro

    Dim conexao As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\tonno\documents\visual studio 2012\Projects\estudoprova\estudoprova\estudo.mdf;Integrated Security=True"
    'FUNÇÃO VERIFICA O ULTIMO CODIGO A SER INSERIDO
    Public Function incremento(ByRef x As Long)
        Dim cn As New SqlConnection(conexao)
        Dim sqlConfere As String
        sqlConfere = "SELECT MAX(idcliente) FROM pessoa"
        Dim sqlExec As New SqlCommand(sqlConfere, cn)
        incremento = sqlExec
        cn.Close()
    End Function

    Private Sub txb1_TextChanged(sender As Object, e As EventArgs) Handles txb1.TextChanged
        txb1.Text = incremento()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

    End Sub

    Private Sub btn_consulta_Click(sender As Object, e As EventArgs) Handles btn_consulta.Click
        consulta.Show()
    End Sub

End Class
