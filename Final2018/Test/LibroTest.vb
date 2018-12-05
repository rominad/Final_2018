Imports Final2018
Module LibroTest
    Sub Main()
        Try
            Dim libro As New Libro("a", "titulo del libro", 200)
            Console.WriteLine(libro.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim editor As New Editor(37876663, "nombreEditor")
            Dim libro2 As New Libro("asd123", "titulo", 200)
            Dim autor As New Autor(37876663, "nombreAutor")
            Dim autor2 As New Autor(37876663, "nombreAutor2")
            editor.AddMaterial(libro2)
            autor.AddMaterial(libro2)

            Material.PorcentajeEditorPorLibro = 10


            Console.WriteLine("ganancia porcentaje Autor: {0}", libro2.GananciaPorcentajePorAutor())
            Console.WriteLine("Titulo:" & libro2.Titulo)
            Console.WriteLine("ISBN:" & libro2.ISBN)
            Console.WriteLine("MontoContrato:" & libro2.MontoContrato)
            Console.WriteLine("GananciaEditor:" & libro2.GananciaEditor())
            Console.WriteLine(libro2.ToString())

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
