
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class SBlockData1 : CVariable
    {
        public CMatrix4x4 unk1;
		public CMatrix4x4 unk2;
		public CMatrix4x4 position;
		public CMatrix4x4 unk3;
		

        public SBlockData1(CR2WFile cr2w) : base(cr2w)
        {
            unk1 = new CMatrix4x4(cr2w) { Name = "startingIndex" };
			unk2 = new CMatrix4x4(cr2w){ Name = "endingIndex" };
            position = new CMatrix4x4(cr2w){ Name = "chunkIndex" };
            unk3 = new CMatrix4x4(cr2w){ Name = "boneIndex" };

        }

        public override void Read(BinaryReader file, uint size)
        {
                unk1.Read(file,size);
				unk2.Read(file,size);
				position.Read(file,size);
				unk3.Read(file,size);
				
        }

        public override void Write(BinaryWriter file)
        {
                unk1.Write(file);
				unk2.Write(file);
				position.Write(file);
				unk3.Write(file);
				
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SBlockData1(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (SBlockData1)base.Copy(context);
            
                var.unk1 = (CMatrix4x4)unk1.Copy(context);
				var.unk2 = (CMatrix4x4)unk2.Copy(context);
				var.position = (CMatrix4x4)position.Copy(context);
				var.unk3 = (CMatrix4x4)unk3.Copy(context);
				
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>()
            {
                unk1,
				unk2,
				position,
				unk3, 
            };
            return list;
        }
    }
}
