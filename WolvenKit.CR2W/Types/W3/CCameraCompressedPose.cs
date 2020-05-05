using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CCameraCompressedPose : CVector
    {
        public CBytes bytes1;
        public CFloat float1;
        public CFloat float2;
        public CBytes bytes2;

        public CCameraCompressedPose(CR2WFile cr2w)
            : base(cr2w)
        {
            bytes1 = new CBytes(cr2w) { Name = nameof(bytes1) };
            float1 = new CFloat(cr2w) { Name = nameof(float1) };
            float2 = new CFloat(cr2w) { Name = nameof(float2) };
            bytes2 = new CBytes(cr2w) { Name = nameof(bytes2) };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCameraCompressedPose(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
               
            bytes1.Read(file, 20);
            float1.Read(file, 4);
            float2.Read(file, 4);
            bytes2.Read(file, 25);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            bytes1.Write(file);
            float1.Write(file);
            float2.Write(file);
            bytes2.Write(file);

        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                bytes1,
                float1,
                float2,
                bytes2,
            };
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CCameraCompressedPose)base.Copy(context);

            var.bytes1 = (CBytes)bytes1.Copy(context);
            var.float1 = (CFloat)float1.Copy(context);
            var.float2 = (CFloat)float2.Copy(context);
            var.bytes2 = (CBytes)bytes2.Copy(context);

            return var;
        }

        public override string ToString()
        {
            return "";
        }
        
    }
}