Imports Final2018
Module BorradorTest
    Sub Main()
        Try
            Dim editor As New Editor(37876663, "nombreEditor")
            Dim autor As New Autor(37876663, "nombreAutor")
            Dim autor2 As New Autor(37876663, "nombreAutor2")
            Dim borrador As New Borrador("titulo", 100)
            Material.PorcentajeEditorPorBorrador = 10
            editor.AddMaterial(borrador)
            Console.WriteLine("Titulo Borrador= {0}", borrador.Titulo)
            Console.WriteLine("Precio Borrador= {0}", borrador.MontoContrato)
            Console.WriteLine("Ganancia editor= {0}", borrador.GananciaEditor())
            Console.WriteLine("Ganancia % Autor= {0}", borrador.GananciaPorcentajePorAutor())
            Console.WriteLine(borrador.ToString())


        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim borrador2 As New Borrador("ti", 100)
            Console.WriteLine(borrador2.ToString())

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
        Console.ReadKey()
    End Sub
End Module
