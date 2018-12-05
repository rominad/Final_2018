Public Class Libro
    Inherits Material
    Private _isbn As String

    Public Property ISBN As String
        Get
            Return _isbn
        End Get
        Set(value As String)
            If value.Length < 3 Or value.Length > 20 Then
                Throw New Exception("El ISBN debe contener mas de 3 caracteres y menos de 20!")
            Else
                _isbn = value
            End If
        End Set
    End Property
    Public Overrides Function GananciaPorcentajePorAutor() As Byte
        Return 100 - PorcentajeEditorPorLibro / GetALLAutores.Count()
    End Function
    Public Overrides Function ToString() As String
        Return Titulo & "-" & MontoContrato & "-" & Editor.Nombre
    End Function
    Sub New(isbn As String, titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
        Me.ISBN = isbn
    End Sub

End Class
