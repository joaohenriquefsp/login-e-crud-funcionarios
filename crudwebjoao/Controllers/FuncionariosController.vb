Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports crudwebjoao
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security

Namespace Controllers
    Public Class FuncionariosController
        Inherits System.Web.Mvc.Controller

        Private db As New FuncionarioContexto

        ' GET: Funcionarios
        Async Function Index() As Task(Of ActionResult)

            Return View(Await db.Funcionarios.ToListAsync())
        End Function

        ' GET: Funcionarios/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim funcionario As Funcionario = Await db.Funcionarios.FindAsync(id)
            If IsNothing(funcionario) Then
                Return HttpNotFound()
            End If
            Return View(funcionario)
        End Function

        ' GET: Funcionarios/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Funcionarios/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="ID,Nome,Sexo,Cargo,Salario,Cidade,Email")> ByVal funcionario As Funcionario) As Task(Of ActionResult)

            If ModelState.IsValid Then
                db.Funcionarios.Add(funcionario)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(funcionario)
        End Function

        ' GET: Funcionarios/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim funcionario As Funcionario = Await db.Funcionarios.FindAsync(id)
            If IsNothing(funcionario) Then
                Return HttpNotFound()
            End If
            Return View(funcionario)
        End Function

        ' POST: Funcionarios/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="ID,Nome,Sexo,Cargo,Salario,Cidade,Email")> ByVal funcionario As Funcionario) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(funcionario).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(funcionario)
        End Function

        ' GET: Funcionarios/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim funcionario As Funcionario = Await db.Funcionarios.FindAsync(id)
            If IsNothing(funcionario) Then
                Return HttpNotFound()
            End If
            Return View(funcionario)
        End Function

        ' POST: Funcionarios/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim funcionario As Funcionario = Await db.Funcionarios.FindAsync(id)
            db.Funcionarios.Remove(funcionario)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
