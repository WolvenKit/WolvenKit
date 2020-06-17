using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    /// <summary>
    /// A generic wrapper class for a single CVariable
    /// Format: [uint size] [ushort nameID] [ushort typeID] [byte[size] data]
    /// </summary>
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDPrimitive, EREDMetaInfo.REDComplex)]
    public class CVariableWrapper2 : CVariable
    {
        [RED] public CVariable Variable { get; set; }

        public CVariableWrapper2(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            CVariable parsedvar = null;
            var varsize = file.ReadUInt32();
            var buffer = file.ReadBytes((int)varsize - 4);
            using (var ms = new MemoryStream(buffer))
            using (var br = new BinaryReader(ms))
            {
                var nameId = br.ReadUInt16();
                var typeId = br.ReadUInt16();

                if (nameId == 0)
                {
                    return;
                }

                var typename = cr2w.names[typeId].Str;
                var varname = cr2w.names[nameId].Str;

                parsedvar = CR2WTypeManager.Create(typename, varname, cr2w, this);

                parsedvar.Read(br, size);
            }

            Variable = parsedvar;
        }

        public override void Write(BinaryWriter file)
        {

            UInt32 varsize = 4 + 4; //4 for the uint32 varsize, 4 for 2 x uint16 typeID and nameID
            byte[] varvalue;

            // use a temporary stream to write the variable and get the length of the variable
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                Variable.Write(bw);
                varsize += (UInt32)ms.Length;
                varvalue = ms.ToArray();
            }

            // write variable
            file.Write(varsize);
            file.Write(Variable.nameId);
            file.Write(Variable.typeId);
            file.Write(varvalue);
        }

        public override string ToString()
        {
            return Variable.ToString();
        }

        public override CVariable Create(CR2WFile cr2w) => new CVariableWrapper2(cr2w);
    }
}
