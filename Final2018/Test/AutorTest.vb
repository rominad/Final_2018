Imports Final2018
Module AutorTest
    Sub Main()
        Try
            Dim autor As New Autor(33081661, "n")
            Console.WriteLine(autor.ToString())
            Console.WriteLine(autor.CalcularGanancia())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            Dim autor As New Autor(222, "nombreAutor1")
            Dim material As New Libro(123123, "material", 100.0)
            Dim material2 As New Borrador("material2", 200.0)
            Dim material3 As New Borrador("material3", 400.0)
            autor.AddMaterial(material)
            autor.AddMaterial(material2)
            autor.AddMaterial(material3)
            For Each valor In autor.GetAllMateriales()
                Console.WriteLine("Titulo= {0}", valor.Titulo)
                Console.WriteLine("Precio= {0}", valor.MontoContrato)
                Console.WriteLine("Ganancia %Autor=  {0}", valor.GananciaPorcentajePorAutor)
            Next
            Console.WriteLine("CalcularGanancia=  {0}", autor.CalcularGanancia)
            Console.WriteLine(autor.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try


    End Sub
End Module
