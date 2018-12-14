Public MustInherit Class Material
    Private _titulo As String
    Private _montoContrato As Decimal
    Shared _porcentajeEditorPorBorrador As Byte
    Shared _porcentajeEditorPorLibro As Byte
    Protected _autores As List(Of Autor)
    Private _editor As Editor

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            If value.Length < 3 Or value.Length > 256 Then
                Throw New Exception("El titulo debe contener mas de 3 caracteres y menos de 256!")
            Else
                _titulo = value
            End If
        End Set
    End Property
    Public Property MontoContrato As Decimal
        Get
            Return _montoContrato
        End Get
        Set(value As Decimal)
            If value < 0 Then
                Throw New ArgumentException("no se admiten Valores Negativos para Montos de Contratos!")
            Else
                _montoContrato = value
            End If
        End Set
    End Property
    Public Shared Property PorcentajeEditorPorBorrador As Byte
        Get
            Return _porcentajeEditorPorBorrador
        End Get
        Set(value As Byte)
            If value < 0 Then
                Throw New ArgumentException("no se admiten Valores Negativos para %EditorBorrador!")
            Else
                _porcentajeEditorPorBorrador = value
            End If
        End Set
    End Property
    Public Shared Property PorcentajeEditorPorLibro As Byte
        Get
            Return _porcentajeEditorPorLibro
        End Get
        Set(value As Byte)
            If value < 0 Then
                Throw New ArgumentException("no se admiten Valores Negativos para %EditorLibro!")
            Else
                _porcentajeEditorPorLibro = value
            End If
        End Set
    End Property
    Public Property Editor As Editor
        Get
            Return _editor
        End Get
        Friend Set(value As Editor)
            _editor = value
        End Set
    End Property
    Public MustOverride Function GananciaPorcentajePorAutor() As Byte

    Public Function GananciaEditor() As Decimal
        'falta filtrar por tipo de porcentaje XD
        'Return MontoContrato * PorcentajeEditorPorLibro / 100
        'Fabio comment: se ejecuta segun de quien es el tipo de la instancia los siguiente
        If TypeOf Me Is Libro Then
            Return MontoContrato * PorcentajeEditorPorLibro / 100
        Else
            Return MontoContrato * PorcentajeEditorPorBorrador / 100
        End If
    End Function
    Public Overrides Function ToString() As String
        'Fabio comment: no tiene ninguna referencia ni fue solitado
        Return Titulo
    End Function
    'bidireccional multiple
    'clase dependiente ===================================
    Friend Sub AddAutor(value As Autor)
        _autores.Add(value)
    End Sub
    Friend Sub RemoveAutor(autor As Autor)
        _autores.Remove(autor)
    End Sub
    Public Function GetALLAutores() As List(Of Autor)
        Return _autores
    End Function
    ' ===================================
    Sub New(titulo As String, montoContrato As Decimal)
        Me.Titulo = titulo
        Me.MontoContrato = montoContrato
        _autores = New List(Of Autor)
    End Sub
End Class
