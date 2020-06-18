using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CRagdoll : CResource
    {
        [RED("windScaler")] public CFloat WindScaler { get; set; }

        [RED("densityScaler")] public CFloat DensityScaler { get; set; }

        [RED("autoStopDelay")] public CFloat AutoStopDelay { get; set; }

        [RED("autoStopTime")] public CFloat AutoStopTime { get; set; }

        [RED("autoStopSpeed")] public CFloat AutoStopSpeed { get; set; }

        [RED("resetDampingAfterStop")] public CBool ResetDampingAfterStop { get; set; }

        [RED("forceWakeUpOnAttach")] public CBool ForceWakeUpOnAttach { get; set; }

        [RED("customDynamicGroup")] public CPhysicalCollision CustomDynamicGroup { get; set; }

        [RED("disableConstrainsTwistAxis")] public CBool DisableConstrainsTwistAxis { get; set; }

        [RED("disableConstrainsSwing1Axis")] public CBool DisableConstrainsSwing1Axis { get; set; }

        [RED("disableConstrainsSwing2Axis")] public CBool DisableConstrainsSwing2Axis { get; set; }

        [RED("jointBounce")] public CFloat JointBounce { get; set; }

        [RED("modifyTwistLower")] public CFloat ModifyTwistLower { get; set; }

        [RED("modifyTwistUpper")] public CFloat ModifyTwistUpper { get; set; }

        [RED("modifySwingY")] public CFloat ModifySwingY { get; set; }

        [RED("modifySwingZ")] public CFloat ModifySwingZ { get; set; }

        [RED("projectionIterations")] public CInt32 ProjectionIterations { get; set; }

        [REDBuffer] public CXml Ragdolldata { get; set; }

        public CRagdoll(CR2WFile cr2w) : base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            if (val is CXml)
            {
                Ragdolldata = (CXml) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CRagdoll(cr2w);
        }
    }
}
