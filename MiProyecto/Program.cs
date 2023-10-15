using System;
using System.Diagnostics;
using System.IO;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nombre del archivo HTML dentro de la carpeta wwwroot.
            string nombreArchivoHTML = "index.html";

            // Obtén la ruta completa al archivo HTML.
            string rutaArchivoHTML = Path.Combine("wwwroot", nombreArchivoHTML);

            if (File.Exists(rutaArchivoHTML))
            {
                try
                {
                    // Abre el archivo HTML en el navegador web predeterminado del sistema.
                    Process.Start(rutaArchivoHTML);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al abrir el archivo HTML: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El archivo HTML no existe en la ubicación especificada.");
            }
        }
    }
}
