using System;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;

namespace WolvenKit.Utils
{
    public static class XmlSerializer
    {

        public static void SerializeObject<T>(XmlWriter xw, T val)
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(T));
            using (var ms = new MemoryStream())
            {
                ser.WriteObject(xw, val);
            }
        }

        public static void SerializeObjectContent<T>(XmlWriter xw, T val)
        {
            DataContractSerializer ser =new DataContractSerializer(typeof(T));
            using (var ms = new MemoryStream())
            {
                ser.WriteObjectContent(xw, val);
            }
        }


        public static void SerializeStartObject<T>(XmlWriter xw, T val)
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(T));
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, val);
            }
        }

        public static void SerializeEndObject<T>(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(T));
            using (var ms = new MemoryStream())
            {
                ser.WriteEndObject(xw);
            }
        }


        //ser.WriteObject(writer, val);
        //writer.Close();

    }
}
