using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GestionDeArchivosTxt
    {
        /// <summary>
        /// Metodo que guarda datos en un archivo con formato txt.
        /// </summary>
        /// <param name="ruta">Ruta donde se creara o guardara el archivo con formato txt.</param>
        /// <param name="datoAGuardar">Dato a guardar en el archivo con formato txt.</param>
        /// <param name="concatena">Criterio recibido para saber si tiene que concatenar el texto o no. True para concatenar, False para no concatenar.</param>
        public static void Txt_Writer(string ruta, string datoAGuardar, bool concatena)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta,concatena))
                {
                    streamWriter.WriteLine(datoAGuardar);
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Ocurrio un error al guardar el archivo");
            }
        }

        /// <summary>
        /// Metodo que lee datos de un archivo con formato txt.
        /// </summary>
        /// <param name="ruta">Ruta donde se leera el archivo con formato txt.</param>
        /// <returns>Devuelve el contenido del archivo leido con formato txt.</returns>
        public static string Txt_Reader(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Ocurrio un error al leer el archivo");
            }
        }
    }
}
