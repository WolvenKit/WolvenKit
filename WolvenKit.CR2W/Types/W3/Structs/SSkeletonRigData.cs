using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class SSkeletonRigData : CVariable
    {
        public CQuaternion position;
        public CQuaternion rotation;
        public CQuaternion scale;

        public SSkeletonRigData(CR2WFile cr2w) : base(cr2w)
        {
            position = new CQuaternion(cr2w) { Name = "position" };
            rotation = new CQuaternion(cr2w) { Name = "rotation" };
            scale = new CQuaternion(cr2w) { Name = "scale" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            position.Read(file, 16);
            rotation.Read(file, 16);
            scale.Read(file, 16);
        }

        public override void Write(BinaryWriter file)
        {
            position.Write(file);
            rotation.Write(file);
            scale.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SSkeletonRigData(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SSkeletonRigData)base.Copy(context);

            var.position = (CQuaternion)position.Copy(context);
            var.rotation = (CQuaternion)rotation.Copy(context);
            var.scale = (CQuaternion)scale.Copy(context);
            

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                position,
                rotation,
                scale
            };
        }

        public override string ToString()
        {
            return $"[{position.ToString()}, {rotation.ToString()}, {scale.ToString()}]";
        }
    }
}