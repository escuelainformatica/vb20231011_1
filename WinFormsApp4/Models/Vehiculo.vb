Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Vehiculo
        Public Property Id As Integer

        Public Property Nombre As String

        Public Property IdMarca As Integer?

        Public Property Precio As Integer?

        Public Property RutPropietario As String

        Public Overridable Property IdMarcaNavigation As Marca

        Public Overridable Property RutPropietarioNavigation As Persona
    End Class
End Namespace
