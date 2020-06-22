using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CRagdoll : CResource
	{
		[RED("windScaler")] 		public CFloat WindScaler { get; set;}

		[RED("densityScaler")] 		public CFloat DensityScaler { get; set;}

		[RED("autoStopDelay")] 		public CFloat AutoStopDelay { get; set;}

		[RED("autoStopTime")] 		public CFloat AutoStopTime { get; set;}

		[RED("autoStopSpeed")] 		public CFloat AutoStopSpeed { get; set;}

		[RED("resetDampingAfterStop")] 		public CBool ResetDampingAfterStop { get; set;}

		[RED("forceWakeUpOnAttach")] 		public CBool ForceWakeUpOnAttach { get; set;}

		[RED("customDynamicGroup")] 		public CPhysicalCollision CustomDynamicGroup { get; set;}

		[RED("disableConstrainsTwistAxis")] 		public CBool DisableConstrainsTwistAxis { get; set;}

		[RED("disableConstrainsSwing1Axis")] 		public CBool DisableConstrainsSwing1Axis { get; set;}

		[RED("disableConstrainsSwing2Axis")] 		public CBool DisableConstrainsSwing2Axis { get; set;}

		[RED("jointBounce")] 		public CFloat JointBounce { get; set;}

		[RED("modifyTwistLower")] 		public CFloat ModifyTwistLower { get; set;}

		[RED("modifyTwistUpper")] 		public CFloat ModifyTwistUpper { get; set;}

		[RED("modifySwingY")] 		public CFloat ModifySwingY { get; set;}

		[RED("modifySwingZ")] 		public CFloat ModifySwingZ { get; set;}

		[RED("projectionIterations")] 		public CInt32 ProjectionIterations { get; set;}

		public CRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CRagdoll(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}