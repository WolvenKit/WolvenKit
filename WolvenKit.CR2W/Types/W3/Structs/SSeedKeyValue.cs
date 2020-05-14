
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class SSeedKeyValue : CVector
    {
        public CUInt32 key;
        public CUInt32 val;
		

        public SSeedKeyValue(CR2WFile cr2w) : base(cr2w)
        {
            key = new CUInt32(cr2w){ Name = "key", Type = "CUInt32"};
            val = new CUInt32(cr2w){ Name = "val", Type = "CUInt32"};
				
        }

        public override void Read(BinaryReader file, uint size)
        {
            key.Read(file,size);
            val.Read(file,size);
				
        }

        public override void Write(BinaryWriter file)
        {
            key.Write(file);
            val.Write(file);
				
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SSeedKeyValue(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SSeedKeyValue)base.Copy(context);
            
            var.key = (CUInt32)key.Copy(context);
            var.val = (CUInt32)val.Copy(context);
				
            
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                key,
                val, 
            };
            return list;
        }
    }
}
