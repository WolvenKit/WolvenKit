using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types.Utils
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = "")]
    public class CVectorWrapper : CVariable
    {
        public CVariable variable;

        public CVectorWrapper(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CVectorWrapper(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            CVariable parsedvar = null;
            var varsize = file.ReadUInt32();
            var buffer = file.ReadBytes((int)varsize - 4);
            using (var ms = new MemoryStream(buffer))
            using (var br = new BinaryReader(ms))
            {

                var typeId = br.ReadUInt16();

                var typename = cr2w.names[typeId].Str;

                parsedvar = CR2WTypeManager.Create(typename, "", cr2w, this);

                parsedvar.Read(br, size);

                //parsedvar.typeId = typeId;
            }

            variable = parsedvar;
        }

        public override void Write(BinaryWriter file)
        {

            UInt32 varsize = 4 + 2; //4 for the uint32 varsize, 2 for uint16 typeID
            byte[] varvalue;

            // use a temporary stream to write the variable and get the length of the variable
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                variable.Write(bw);
                varsize += (UInt32)ms.Length;
                varvalue = ms.ToArray();
            }

            // write variable
            file.Write(varsize);
            file.Write(variable.typeId);
            file.Write(varvalue);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CVectorWrapper)base.Copy(context);

            var.variable = variable.Copy(context);

            return var;
        }

        public override string ToString()
        {
            return variable.ToString();
        }
        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                variable
            };
        }
    }
}
