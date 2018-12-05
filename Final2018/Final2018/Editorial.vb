Public Class Editorial
    Public Shared _materiales As List(Of Material)


    Public Shared Sub AddMaterial(value As Material)
        _materiales.Add(value)
    End Sub
    Public Shared Sub RemoveMaterial(value As Material)
        _materiales.Remove(value)
    End Sub
    Public Shared Function GetAllMateriales() As List(Of Material)
        Return _materiales
    End Function
    Public Shared Function GetAllMateriales(value As Autor) As List(Of Material)
        Dim _listaDeMateriales = New List(Of Material)
        For Each material In _materiales
            If material.GetALLAutores.Contains(value) Then
                _listaDeMateriales.Add(material)
            End If
        Next
        Return _listaDeMateriales
    End Function
    Public Shared Function GetAutor(dni As UInteger) As Autor
        For Each autor In _materiales
            If autor.GetALLAutores.Exists(Function(value) value.Dni = dni) Then
                Return autor.GetALLAutores.Find(Function(value) value.Dni = dni)
            Else
                Throw New Exception("El numero " & dni & " de DNI no existe!")
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function GetAllEmpleados() As List(Of Empleado)
        Dim _empleados As New List(Of Empleado)
        'ver'
        Return _empleados
    End Function
    Shared Sub New()
        _materiales = New List(Of Material)
    End Sub
End Class
