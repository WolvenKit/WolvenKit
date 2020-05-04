using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class CIndexed2dArray : CVector
    {
        [DataMember]
        public CBytes arrays;

        public CIndexed2dArray(CR2WFile cr2w) : base(cr2w)
        {
            arrays = new CBytes(cr2w)
            {
                Name = "Serialized data"
            };
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
            base.Read(file, size);
            arrays.Bytes = file.ReadRemainingData();
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            arrays.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CIndexed2dArray(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(base.GetEditableVariables())
            {
                arrays
            };

            return list;
        }

        public override void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);
                arrays.SerializeToXml(xw);
                ser.WriteEndObject(xw);
            }
        }
    }
}
