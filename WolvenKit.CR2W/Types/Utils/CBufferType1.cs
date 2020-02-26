using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types.Utils
{
    public class CBufferType1 : CVariable
    {

        private CName componentName;
        public CName ComponentName { get => componentName; set => componentName = value; }

        private CGUID guid;
        public CGUID Guid { get => guid; set => guid = value; }

        private CUInt32 sizeofdata;
        public CUInt32 Sizeofdata { get => sizeofdata; set => sizeofdata = value; }

        private CBytes buffer;
        public CBytes Buffer { get => buffer; set => buffer = value; }

        public CBufferType1(CR2WFile cr2w) : base(cr2w)
        {
            componentName = new CName(cr2w)
            {
                Name = "Name",
            };
            guid = new CGUID(cr2w)
            {
                Name = "GUID"
            };
            sizeofdata = new CUInt32(cr2w)
            {
                Name = "Size",
            };
            buffer = new CBytes(cr2w)
            {
                Name = "Data",
            };
        }

        public bool CanRead(BinaryReader file)
        {
            ComponentName.Read(file, 2);
            return !string.IsNullOrEmpty(componentName.Value); // if empty return 0
        }

        /// <summary>
        /// Always call CanRead before calling this method! // FIXME
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public override void Read(BinaryReader file , uint size)
        {
            if (!string.IsNullOrEmpty(componentName.Value))
            {
                guid.Read(file, 16);
                sizeofdata.Read(file, 4);
                buffer.Read(file, sizeofdata.val - 4);
            }
        }

        public override void Write(BinaryWriter file)
        {
            componentName.Write(file);
            if (!string.IsNullOrEmpty(componentName.Value))
            {
                guid.Write(file);
                sizeofdata.val = (uint)buffer.Bytes.Length + 4;
                sizeofdata.Write(file);
                buffer.Write(file);
            }
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBufferType1(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBufferType1)base.Copy(context);

            var.componentName = componentName;
            var.guid = guid;
            var.sizeofdata = sizeofdata;
            var.buffer = buffer;

            return var;
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
            };
            if (!string.IsNullOrEmpty(componentName.Value))
            {
                editableVars.Add(guid);
                editableVars.Add(sizeofdata);
                editableVars.Add(buffer);
            }

            return editableVars;
        }
    }
}
