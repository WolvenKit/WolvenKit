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
    public class CVariableWrapper : CVariable
    {
        public CVariable variable;

        public CVariableWrapper(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CVariableWrapper(cr2w);
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
                var nameId = br.ReadUInt16();

                if (nameId == 0)
                {
                    return;
                }

                var typename = cr2w.names[typeId].Str;
                var varname = cr2w.names[nameId].Str;

                parsedvar = CR2WTypeManager.Get().GetByName(typename, varname, cr2w);

                parsedvar.Read(br, size);

                parsedvar.nameId = nameId;
                parsedvar.typeId = typeId;
            }

            variable = parsedvar;
        }

        public override void Write(BinaryWriter file)
        {

            UInt32 varsize = 4 + 4; //4 for the uint32 varsize, 4 for 2 x uint16 typeID and nameID
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
            file.Write(variable.nameId);
            file.Write(varvalue);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CVariableWrapper)base.Copy(context);

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
