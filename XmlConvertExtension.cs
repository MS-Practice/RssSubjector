using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace RssSubjector
{
    public static class XmlConvertExtension
    {
        public static T DeserializeObject<T>(string xml)
         where T : new()
        {
            if (string.IsNullOrEmpty(xml))
            {
                return new T();
            }

            try
            {
                using var stringReader = new StringReader(xml);
                var serializer = new XmlSerializer(typeof(T));
                var xmlReader = XmlReader.Create(stringReader);

                return (T)serializer.Deserialize(xmlReader);
            }
            catch (Exception)
            {
                return new T();
            }
        }

        public static string SerializeObject<T>(T dataObject)
        {
            if (dataObject == null)
            {
                return string.Empty;
            }
            try
            {
                using var stringWriter = new StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringWriter, dataObject);
                return stringWriter.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
