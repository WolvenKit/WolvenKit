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
    [DataContract(Namespace = "")]
    public class SEntityBufferType1 : CVariable
    {

        private CName componentName;
        public CName ComponentName { get => componentName; set => componentName = value; }

        private CGUID guid;
        public CGUID Guid { get => guid; set => guid = value; }

        private CByteArray2 buffer;
        public CByteArray2 Buffer { get => buffer; set => buffer = value; }

        public SEntityBufferType1(CR2WFile cr2w) : base(cr2w)
        {
            componentName = new CName(cr2w)
            {
                Name = "Name",
            };
            guid = new CGUID(cr2w)
            {
                Name = "GUID"
            };
            buffer = new CByteArray2(cr2w)
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
                buffer.Read(file, size);
            }
        }

        public override void Write(BinaryWriter file)
        {
            componentName.Write(file);
            if (!string.IsNullOrEmpty(componentName.Value))
            {
                guid.Write(file);
                buffer.Write(file);
            }
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SEntityBufferType1(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SEntityBufferType1)base.Copy(context);

            var.componentName = (CName)componentName.Copy(context);
            var.guid = (CGUID)guid.Copy(context);
            var.buffer = (CByteArray2)buffer.Copy(context);

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
                editableVars.Add(buffer);
            }

            return editableVars;
        }
    }
}
