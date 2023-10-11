Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Pai
        Public Property Id As Integer

        Public Property Nombre As String

        Public Overridable ReadOnly Property Marcas As ICollection(Of Marca) = New List(Of Marca)()
    End Class
End Namespace
