using System.Collections.Generic;
using System.IO;
using System;
using WolvenKit.CR2W.Editors;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CSwfTexture : CVector
    {
        public CByteArray swfTexture;

        public CSwfTexture(CR2WFile cr2w) : base(cr2w)
        {
            swfTexture = new CByteArray(cr2w)
            {
                Name = "swfTexture"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            base.Read(file, size);
            var textureSize = Convert.ToInt32( size - (file.BaseStream.Position - pos) );
            swfTexture.Bytes = file.ReadBytes(textureSize);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            file.Write(swfTexture.Bytes);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSwfTexture(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSwfTexture)base.Copy(context);
            var.swfTexture = (CByteArray)swfTexture.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                swfTexture
            };
            return list;
        }
    }
}