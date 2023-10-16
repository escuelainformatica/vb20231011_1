Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Artista
        Public Property Id As Integer

        Public Property Nombre As String

        Public Property Apellido As String

        Public Overridable ReadOnly Property Discos As ICollection(Of Disco) = New List(Of Disco)()
    End Class
End Namespace
