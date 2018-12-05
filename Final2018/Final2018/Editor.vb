Imports Final2018

Public Class Editor
    Implements Empleado
    Private _dni As UInteger
    Private _nombre As String
    Private _materiales As List(Of Material)

    Public Property Dni As UInteger Implements Empleado.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property
    Public Property Nombre As String Implements Empleado.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If (value.Length < 3 Or value.Length > 30) Then
                Throw New Exception("El nombre debe contener mas de 3 caracteres y menos de 30!")
            Else
                _nombre = value
            End If
        End Set
    End Property
    Public Sub AddMaterial(valor As Material)
        If _materiales.Count < 2 Then
            valor.Editor = Me
            _materiales.Add(valor)
        End If
    End Sub
    Public Sub RemoveEditor(valor As Material)
        valor.Editor = Nothing
        _materiales.Remove(valor)
    End Sub
    Public Function GetAllMateriales() As List(Of Material)
        Return _materiales
    End Function
    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        Dim total As Decimal
        For Each material In _materiales
            total += material.GananciaPorcentajePorAutor()
        Next
        Return total
    End Function
    Public Overrides Function ToString() As String
        Return Nombre & " - " & Dni
    End Function
    Sub New(dni As UInteger, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
        _materiales = New List(Of Material)
    End Sub

End Class
