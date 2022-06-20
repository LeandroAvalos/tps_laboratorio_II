using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public static class GestionDeArchivos<T> where T : class
    {
        /// <summary>
        /// Metodo que serializa un archivo en formato xml.
        /// </summary>
        /// <param name="ruta">Ruta donde se creara o guardara el archivo con formato xml.</param>
        /// <param name="datoASerializar">Dato que sera guardado en el archivo con formato xml.</param>
        public static void Xml_Serializer(string ruta, T datoASerializar)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(streamWriter, datoASerializar);
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Ocurrio un error al realizar la serializacion");
            }
        }

        /// <summary>
        /// Metodo que deserializa un archivo en formato xml.
        /// </summary>
        /// <param name="ruta">Ruta donde se leera el archivo a deserializar en formato xml.</param>
        /// <returns>Devuelve el contenido del archivo deserializado.</returns>
        public static T Xml_Reader(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    T objetoDeSerializado = xml.Deserialize(streamReader) as T;
                    return objetoDeSerializado;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Ocurrio un error al realizar la serializacion");
            }
        }

        /// <summary>
        /// Metodo que guarda datos en un archivo con formato txt.
        /// </summary>
        /// <param name="ruta">Ruta donde se creara o guardara el archivo con formato txt.</param>
        /// <param name="datoAGuardar">Dato a guardar en el archivo con formato txt.</param>
        /// <param name="concatena">Criterio recibido para saber si tiene que concatenar el texto o no. True para concatenar, False para no concatenar.</param>
        public static void Txt_Writer(string ruta, T datoAGuardar, bool concatena)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta, concatena))
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
        public static T Txt_Reader(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    T texto = streamReader.ReadToEnd() as T;
                    return texto;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Ocurrio un error al leer el archivo");
            }
        } 
    }
}
