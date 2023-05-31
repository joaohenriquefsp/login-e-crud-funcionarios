Imports System.Data.Entity
Public Class FuncionarioContexto
    Inherits DbContext
    Public Sub New()
        MyBase.New("Cadastro_MVC")
    End Sub
    Public Property Funcionarios() As DbSet(Of Funcionario)
End Class