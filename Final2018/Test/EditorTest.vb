
Imports Final2018
Module EditorTest
    Sub Main()
        'Fabio comment: confusion! editor o autor test?
        Try
            Dim autor As New Editor(33081661, "e")
            Console.WriteLine(autor.ToString())
            Console.WriteLine(autor.CalcularGanancia())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            Dim autor As New Editor(38481661, "nombre editor")
            Dim libro As New Libro("asd123", "titulo1", 200)
            Dim libro2 As New Libro("asd123", "titulo2", 100)
            Dim editor As New Editor(3332343, "nombreEditor")

            editor.AddMaterial(libro)
            autor.AddMaterial(libro)
            autor.AddMaterial(libro2)

            Material.PorcentajeEditorPorLibro = 5
            Material.PorcentajeEditorPorBorrador = 10
            'Fabio comment: Faltan los test de getter

            Console.WriteLine(autor.ToString())
            'Fabio comment: desbordamiento planta el test
            Console.WriteLine("Ganancia Editor: {0}", editor.CalcularGanancia())

            For Each valor In editor.GetAllMateriales()
                Console.WriteLine("Titulo Material= {0}", valor.Titulo)
                Console.WriteLine("Nombre Editor= {0}", valor.Editor.Nombre)
                Console.WriteLine("Monto Contrato=  {0}", valor.MontoContrato)
                Console.WriteLine("Ganancia Editor= {0}", valor.GananciaEditor)
            Next

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try

    End Sub
End Module
