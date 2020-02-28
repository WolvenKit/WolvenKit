
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class SBoneIndiceMapping : CVector
    {
        public CUInt32 startingIndex;
		public CUInt32 endingIndex;
		public CUInt32 chunkIndex;
		public CUInt32 boneIndex;
		

        public SBoneIndiceMapping(CR2WFile cr2w) : base(cr2w)
        {
                startingIndex = new CUInt32(cr2w){ Name = "startingIndex", Type = "CUInt32"};
				endingIndex = new CUInt32(cr2w){ Name = "endingIndex", Type = "CUInt32"};
				chunkIndex = new CUInt32(cr2w){ Name = "chunkIndex", Type = "CUInt32"};
				boneIndex = new CUInt32(cr2w){ Name = "boneIndex", Type = "CUInt32"};
				
        }

        public override void Read(BinaryReader file, uint size)
        {
                startingIndex.Read(file,size);
				endingIndex.Read(file,size);
				chunkIndex.Read(file,size);
				boneIndex.Read(file,size);
				
        }

        public override void Write(BinaryWriter file)
        {
                startingIndex.Write(file);
				endingIndex.Write(file);
				chunkIndex.Write(file);
				boneIndex.Write(file);
				
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SBoneIndiceMapping(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (SBoneIndiceMapping)base.Copy(context);
            
                var.startingIndex = (CUInt32)startingIndex.Copy(context);
				var.endingIndex = (CUInt32)endingIndex.Copy(context);
				var.chunkIndex = (CUInt32)chunkIndex.Copy(context);
				var.boneIndex = (CUInt32)boneIndex.Copy(context);
				
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                startingIndex,
				endingIndex,
				chunkIndex,
				boneIndex, 
            };
            return list;
        }
    }
}
