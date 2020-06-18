using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    class CIndexed2dArray : CVariable
    {
        [DataMember]
        [RED("Serialized Data")] public CByteArray SerializedData { get; set; }

        public CIndexed2dArray(CR2WFile cr2w) : base(cr2w)
        {
            SerializedData = new CByteArray(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            //TODO: Figure this out. Has really no point. Only one file has this and it may be some test meme file.
            //This reads the headers
            //Its the base string which is an array of arrays.
            //base.Read(file, size);
            //var count = file.ReadVLQInt32();
            //for (int i = 0; i < count; i++)
            //{
            //    file.ReadStringDefaultSingle();
            //}

            SerializedData.Bytes = file.ReadRemainingData();
        }

        public override void Write(BinaryWriter file)
        {

            //file.WriteVLQInt32(arrays.array.Count);
            SerializedData.Write(file);
        }

        public override void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);
                SerializedData.SerializeToXml(xw);
                ser.WriteEndObject(xw);
            }
        }

        public override CVariable Create(CR2WFile cr2w) => new CIndexed2dArray(cr2w);
    }
}
