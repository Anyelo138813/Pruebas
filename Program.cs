using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string text = "hola putaaaaa.";
            string archivo = "cezar.txt";

            // Obtener la carpeta base relativa al archivo ejecutable
            string carpetaBase = AppDomain.CurrentDomain.BaseDirectory;

            // Combinar la carpeta base y el archivo para obtener el path completo
            string path = Path.Combine(carpetaBase, "archivos", archivo);

            // Verificar si el archivo ya existe antes de crearlo
            if (File.Exists(path))
            {
                Console.WriteLine("El archivo ya existe.");
                Console.WriteLine("Texto en el archivo:");
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                // Crear la carpeta "archivos" si no existe
                Directory.CreateDirectory(Path.Combine(carpetaBase, "archivos"));

                // Crear el archivo y escribir el texto dentro
                File.WriteAllText(path, text);
                Console.WriteLine("Archivo creado con éxito.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
