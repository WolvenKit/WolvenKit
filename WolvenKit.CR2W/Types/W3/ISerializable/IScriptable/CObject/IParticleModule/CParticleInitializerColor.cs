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
    public class CParticleInitializerColor : CVariable
    {
        public CBufferVLQ<CVector3D> color;

        public CParticleInitializerColor(CR2WFile cr2w) : base(cr2w)
        {
            color = new CBufferVLQ<CVector3D>(cr2w, _ => new CVector3D(_)) { Name = "color" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            color.Read(file, 2);
        }

        public override void Write(BinaryWriter file)
        {
            color.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CParticleInitializerColor(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CParticleInitializerColor)base.Copy(context);

            var.color = (CBufferVLQ<CVector3D>)color.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                color,
            };
        }

        public override string ToString()
        {
            return $"";
        }
    }
}