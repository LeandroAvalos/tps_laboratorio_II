using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public static class GestionDeArchivosSerializados<T> where T : class
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
        /// Metodo que serializa un archivo en formato json.
        /// </summary>
        /// <param name="ruta">Ruta donde se creara o guardara el archivo con formato json.</param>
        /// <param name="datoASerializar">Dato que sera guardado en el archivo con formato json.</param>
        public static void Json_Serializer(string ruta, T datoASerializar)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    JsonSerializerOptions opcionesSerializacion = new JsonSerializerOptions();
                    opcionesSerializacion.WriteIndented = true;
                    string jsonASerializar = JsonSerializer.Serialize(datoASerializar, opcionesSerializacion);
                    streamWriter.WriteLine(jsonASerializar);
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Ocurrio un error al realizar la serializacion");
            }
        }

        /// <summary>
        /// Metodo que deserializa un archivo en formato json.
        /// </summary>
        /// <param name="ruta">Ruta donde se leera el archivo a deserializar en formato json.</param>
        /// <returns>Devuelve el contenido del archivo deserializado.</returns>
        public static T Json_Reader(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    string contenidoDelArchivo = streamReader.ReadToEnd();

                    return JsonSerializer.Deserialize<T>(contenidoDelArchivo);
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Ocurrio un error al realizar la serializacion");
            }
        }
    }
}
