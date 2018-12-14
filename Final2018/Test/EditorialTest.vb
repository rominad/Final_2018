Imports Final2018
'Fabio comment: Este module lo agregue me
Module EditorialTest
    Sub main()
        Dim aut As New Autor(111, "Ramon")
        Dim aut2 As New Autor(222, "Jose")
        Dim edit As New Editor(333, "pepe")
        Dim edit2 As New Editor(444, "Nino")
        Dim mat As New Libro(123123, "Libro 1", 10000)
        Dim mat2 As New Borrador("borrador A", 2000)
        Dim mat3 As New Borrador("borrador B", 5000)
        aut.AddMaterial(mat)
        aut.AddMaterial(mat2)
        aut.AddMaterial(mat3)
        aut2.AddMaterial(mat2)
        edit.AddMaterial(mat)
        edit2.AddMaterial(mat2)
        edit2.AddMaterial(mat3)
        Editorial.AddMaterial(mat)
        Editorial.AddMaterial(mat2)
        Editorial.AddMaterial(mat3)
        Console.WriteLine("Todos los materiales ToString:")
        For Each material In Editorial.GetAllMateriales
            Console.WriteLine(material.ToString)
        Next

        MostrarAutorMateriales(aut)
        MostrarAutorMateriales(aut2)

        BuscarAutorPorDNI(222)
        BuscarAutorPorDNI(333)

        Console.WriteLine("Lista de empleados")
        For Each empleado In Editorial.GetAllEmpleados
            Console.WriteLine(empleado)
        Next
    End Sub

    Private Sub BuscarAutorPorDNI(dni As UInteger)
        Try
            Console.WriteLine("Buscando autor  por dni " & dni)
            Console.WriteLine("material.ToString: " & Editorial.getAutor(dni).ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub MostrarAutorMateriales(aut As Autor)
        Console.WriteLine("Mostrar materiales del autor " & aut.ToString)
        For Each material In Editorial.getALLMateriales(aut)
            Console.WriteLine(material.ToString)
        Next
    End Sub
End Module
