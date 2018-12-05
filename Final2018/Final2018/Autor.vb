Imports Final2018

Public NotInheritable Class Autor
    Implements Empleado
    Private _dni As UInteger
    Private _nombre As String
    Private _materiales As List(Of Material)
    Public Property Dni As UInteger Implements Empleado.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            If value < 0 Then
                Throw New ArgumentException("No se admiten Valores Negativos para el DNI!")
            Else
                _dni = value
            End If
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
    'bidireccional multiple
    'clase responsable ===================================
    Public Sub AddMaterial(valor As Material)
        If valor.GetALLAutores().Count() >= 3 Then
            Throw New Exception("Solo se pueden agregar tres autores!")
        Else
            valor.AddAutor(Me)
            _materiales.Add(valor)
        End If
    End Sub
    Public Sub RemoveMaterial(valor As Material)
        'valor.Autor = Nothing
        valor.RemoveAutor(Me)
        _materiales.Remove(valor)
    End Sub
    Public Function GetAllMateriales() As List(Of Material)
        Return _materiales
    End Function
    ' ===================================
    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        Dim Total As Decimal
        For Each valor In _materiales
            Total += valor.MontoContrato * valor.GananciaPorcentajePorAutor / 100
        Next
        Return Total

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
