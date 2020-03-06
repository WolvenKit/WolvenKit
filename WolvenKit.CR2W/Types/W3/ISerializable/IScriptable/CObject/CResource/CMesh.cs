using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;

namespace WolvenKit.CR2W.Types
{
    public class CMesh : CVector
    {
        // ATTENTION: don't read and write like a normal VLQ array
        // this one is padded by 4 bytes after each inner list
        public CBufferVLQ<CPaddedBuffer<CUInt16>> chunkgroupIndeces; 

        public CBufferVLQ<CName> boneNames;
        public CBufferVLQ<CMatrix4x4> bonematrices;
        public CBufferVLQ<CFloat> block3;
        public CBufferVLQ<CUInt32> boneIndecesMappingBoneIndex;
        
            
        public CMesh(CR2WFile cr2w) :
            base(cr2w)
        {
            chunkgroupIndeces = new CBufferVLQ<CPaddedBuffer<CUInt16>>(cr2w, x => new CPaddedBuffer<CUInt16>(x, _ => new CUInt16(_) { Type = "Uint16" })
            {
                Type = "CPaddedBuffer<Uint16>"
            })
            {
                Name = "chunkgroupIndeces",
                Type = "CBuffer<CPaddedBuffer<Uint16>>"
            };

            boneNames = CBuffers.CreateCNameBuffer(cr2w, "boneNames");
            bonematrices = new CBufferVLQ<CMatrix4x4>(cr2w, _ => new CMatrix4x4(_) { Type = "CMatrix4x4" })
            {
                Name = "bonematrices",
                Type = "CBuffer<CMatrix4x4>"
            };
            block3 = CBuffers.CreateFloatBuffer(cr2w, "block3");
            boneIndecesMappingBoneIndex = CBuffers.CreateUInt32Buffer(cr2w, "boneIndecesMappingBoneIndex");
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            chunkgroupIndeces.Read(file, size);
            boneNames.Read(file, 2);
            bonematrices.Read(file, 64);
            block3.Read(file, 4);
            boneIndecesMappingBoneIndex.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            chunkgroupIndeces.Write(file);
            boneNames.Write(file);
            bonematrices.Write(file);
            block3.Write(file);
            boneIndecesMappingBoneIndex.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CMesh(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CMesh)base.Copy(context);

            var.chunkgroupIndeces = (CBufferVLQ<CPaddedBuffer<CUInt16>>)chunkgroupIndeces.Copy(context);
            var.boneNames = (CBufferVLQ<CName>)boneNames.Copy(context);
            var.bonematrices = (CBufferVLQ<CMatrix4x4>)bonematrices.Copy(context);
            var.block3 = (CBufferVLQ<CFloat>)block3.Copy(context);
            var.boneIndecesMappingBoneIndex = (CBufferVLQ<CUInt32>)boneIndecesMappingBoneIndex.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                chunkgroupIndeces,
                boneNames,
                bonematrices,
                block3,
                boneIndecesMappingBoneIndex,
            };
        }
    }
}