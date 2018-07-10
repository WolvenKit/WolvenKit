using System.Collections.Generic;
using System.IO;
using System;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CCubeTexture : CVector
    {
        public CByteArray cubeTexture;
        public CUInt32 m_textureCacheKey;
        public CUInt16 m_residentMip;
        public CUInt16 m_encodedFormat;
        public CUInt16 m_edgeSize;
        public CUInt16 m_mipCount;

        public CCubeTexture(CR2WFile cr2w) : base(cr2w)
        {
            cubeTexture = new CByteArray(cr2w)
            {
                Name = "cubeTexture"
            };
            m_textureCacheKey = new CUInt32(cr2w)
            {
                Name = "TextureCacheKey"
            };
            m_residentMip = new CUInt16(cr2w)
            {
                Name = "Resident mip"
            };
            m_encodedFormat = new CUInt16(cr2w)
            {
                Name = "Encoded format"
            };
            m_edgeSize = new CUInt16(cr2w)
            {
                Name = "Edge size"
            };
            m_mipCount = new CUInt16(cr2w)
            {
                Name = "Mip count"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            base.Read(file, size);
            m_textureCacheKey.Read(file,size);
            m_residentMip.Read(file,size);
            m_encodedFormat.Read(file,size);
            m_edgeSize.Read(file,size);
            m_mipCount.Read(file,size);
            var textureSize = Convert.ToInt32( size - (file.BaseStream.Position - pos) );
            cubeTexture.Bytes = file.ReadBytes(textureSize);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            m_textureCacheKey.Write(file);
            m_residentMip.Write(file);
            m_encodedFormat.Write(file);
            m_edgeSize.Write(file);
            m_mipCount.Write(file);
            file.Write(cubeTexture.Bytes);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCubeTexture(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CCubeTexture)base.Copy(context);
            var.cubeTexture = (CByteArray)cubeTexture.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                m_textureCacheKey,
                m_residentMip,
                m_encodedFormat,
                m_edgeSize,
                m_mipCount,
                cubeTexture
            };
            return list;
        }
    }
}