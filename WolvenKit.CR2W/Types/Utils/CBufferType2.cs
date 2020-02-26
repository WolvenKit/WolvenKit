using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class CBufferType2Item : CVariable
    {
        private CVariable variable;
        public CVariable Variable { get => variable; set => variable = value; }

        public CBufferType2Item(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBufferType2Item(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            CVariable parsedvar = null;
            var varsize = file.ReadUInt32();
            var buffer = file.ReadBytes((int)varsize - 4);
            using (var ms = new MemoryStream(buffer))
            using (var br2 = new BinaryReader(ms))
            {

                var typeId = br2.ReadUInt16();
                var nameId = br2.ReadUInt16();

                if (nameId == 0)
                {
                    return;
                }

                var typename = cr2w.names[typeId].str;
                var varname = cr2w.names[nameId].str;

                parsedvar = CR2WTypeManager.Get().GetByName(typename, varname, cr2w);

                parsedvar.Read(br2, size);

                parsedvar.nameId = nameId;
                parsedvar.typeId = typeId;

                // Enums are behaving weird
                // they seem to have size 4 ( 2 for the actual Enum Cname, and 2 null bytes)
                // however, they can come as arrays? e.g. 2 bytes first enum, 2 bytes second enum, 2 null bytes
                // but the variable name is not an array, so I don't know what to do with them
                // and not all enums do that (ELightUsageMask does it)
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
    }


    /// <summary>
    /// 
    /// </summary>
    public class CBufferType2 : CVariable
    {
        private CName componentName;
        public CName ComponentName { get => componentName; set => componentName = value; }

        private CUInt32 sizeofdata;
        public CUInt32 Sizeofdata { get => sizeofdata; set => sizeofdata = value; }

        private List<CBufferType2Item> variables;
        public List<CBufferType2Item> Variables { get => variables; set => variables = value; }


        public CBufferType2(CR2WFile cr2w) : base(cr2w)
        {
            componentName = new CName(cr2w)
            {
                Name = "Name",
            };
            sizeofdata = new CUInt32(cr2w)
            {
                Name = "Size",
            };
            variables = new List<CBufferType2Item>();
            /*variables = new CArray("", "CBufferType2Item", true, cr2w)
            {
                Name = "Variables",
            };*/

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBufferType2(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            sizeofdata.Read(file, 4);
            componentName.Read(file, 2);

            var count = file.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                var buffer2item = new CBufferType2Item(cr2w);
                buffer2item.Read(file, 0);
                variables.Add(buffer2item);
            }
            //variables.Read(file, (uint)sizeofdata.val - 4 - 2);
        }

        public override void Write(BinaryWriter file)
        {

            sizeofdata.val =  4; // 4 for the uint32 varsize
            byte[] bytes;

            // use a temporary stream to write the variables and get the overall length of the component
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                componentName.Write(bw);

                bw.Write((uint)variables.Count);
                foreach (var item in variables)
                {
                    item.Write(bw);
                }
                //variables.Write(bw);

                sizeofdata.val += (UInt32)ms.Length;
                bytes = ms.ToArray();
            }

            sizeofdata.Write(file);
            file.Write(bytes);
        }

        public override string ToString()
        {
            return componentName.Value;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var editableVars = new List<IEditableVariable>()
            {
                componentName,
                sizeofdata,
                //variables
            };
            foreach (var item in variables)
            {
                editableVars.Add(item.Variable);
            }

            return editableVars;
        }

    }
}
