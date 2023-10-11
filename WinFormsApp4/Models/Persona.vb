Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Persona
        Public Property Rut As String

        Public Property Nombre As String

        Public Overridable ReadOnly Property Vehiculos As ICollection(Of Vehiculo) = New List(Of Vehiculo)()
    End Class
End Namespace
