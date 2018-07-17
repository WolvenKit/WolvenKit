using System.Collections.Generic;
using System.IO;
using System;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CCubeTexture : CVector
    {
        public CDateTime importFileTimeStamp;
        public CString importFile;


        public CubeFace left;
        public CubeFace right;
        public CubeFace front;
        public CubeFace back;
        public CubeFace top;
        public CubeFace bottom;

        public CName compression;
        public CUInt32 targetFaceSize;
        public CName strategy;


        public CCubeTexture(CR2WFile cr2w) : base(cr2w)
        {
            importFileTimeStamp = new CDateTime(cr2w)
            {
                Name = "importFileTimeStamp"
            };
            importFile = new CString(cr2w)
            {
                Name = "importFile",
                Type = "String"
            };

            left = new CubeFace(cr2w)
            {
                Name = "left"
            };
            right = new CubeFace(cr2w)
            {
                Name = "right"
            };
            front = new CubeFace(cr2w)
            {
                Name = "front"
            };
            back = new CubeFace(cr2w)
            {
                Name = "back"
            };
            top = new CubeFace(cr2w)
            {
                Name = "top"
            };
            bottom = new CubeFace(cr2w)
            {
                Name = "bottom"
            };

            compression = new CName(cr2w)
            {
                Name = "compression"
            };
            targetFaceSize = new CUInt32(cr2w)
            {
                Name = "targetFaceSize"
            };
            strategy = new CName(cr2w)
            {
                Name = "strategy"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            
            importFileTimeStamp.Read(file,size);
            importFile.Read(file,size);

            left.Read(file,size);
            right.Read(file,size);
            front.Read(file,size);
            back.Read(file,size);
            top.Read(file,size);
            bottom.Read(file,size);

            compression.Read(file,size);
            targetFaceSize.Read(file,size);
            strategy.Read(file,size);
        }

        public override void Write(BinaryWriter file)
        {
            
            importFileTimeStamp.Write(file);
            importFile.Write(file);

            left.Write(file);
            right.Write(file);
            front.Write(file);
            back.Write(file);
            top.Write(file);
            bottom.Write(file);

            compression.Write(file);
            targetFaceSize.Write(file);
            strategy.Write(file);
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
            var.importFileTimeStamp = (CDateTime)importFileTimeStamp.Copy(context);
            var.importFile = (CString) importFile.Copy(context);

            var.left = (CubeFace) left.Copy(context);
            var.right = (CubeFace) right.Copy(context);
            var.front = (CubeFace) front.Copy(context);
            var.back = (CubeFace) back.Copy(context);
            var.top = (CubeFace) top.Copy(context);
            var.bottom = (CubeFace) bottom.Copy(context);

            var.compression = (CName) compression.Copy(context);
            var.targetFaceSize = (CUInt32) targetFaceSize.Copy(context);
            var.strategy = (CName) strategy.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                importFileTimeStamp,
                importFile,

                left,
                right,
                front,
                back,
                top,
                bottom,

                compression,
                targetFaceSize,
                strategy
            };
        }
    }

    public class CubeFace : CVariable
    {
        public CHandle m_texture;
        public CHandle sourceTexture;
        public CBool m_rotate;
        public CBool m_flipX;
        public CBool m_flipY;


        public CubeFace(CR2WFile cr2w) : base(cr2w)
        {
            m_texture = new CHandle(cr2w)
            {
                Name = "m_texture",
                Type = "handle:CBitmapTexture"
            };
            sourceTexture = new CHandle(cr2w)
            {
                Name = "sourceTexture",
                Type = "handle:CSourceTexture"
            };
            m_rotate = new CBool(cr2w)
            {
                Name = "m_rotate"
            };
            m_flipX = new CBool(cr2w)
            {
                Name = "m_flipX"
            };
            m_flipY = new CBool(cr2w)
            {
                Name = "m_flipY"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            m_texture.Read(file,size);
            sourceTexture.Read(file,size);
            m_rotate.Read(file,size);
            m_flipX.Read(file,size);
            m_flipY.Read(file,size);
        }

        public override void Write(BinaryWriter file)
        {
            m_texture.Write(file);
            sourceTexture.Write(file);
            m_rotate.Write(file);
            m_flipX.Write(file);
            m_flipY.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CubeFace(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
               m_texture,
               sourceTexture,
               m_rotate,
               m_flipX,
               m_flipY
            };
        }
    }
}