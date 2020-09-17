using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CRagdoll : CResource
	{
		[Ordinal(1)] [RED("windScaler")] 		public CFloat WindScaler { get; set;}

		[Ordinal(2)] [RED("densityScaler")] 		public CFloat DensityScaler { get; set;}

		[Ordinal(3)] [RED("autoStopDelay")] 		public CFloat AutoStopDelay { get; set;}

		[Ordinal(4)] [RED("autoStopTime")] 		public CFloat AutoStopTime { get; set;}

		[Ordinal(5)] [RED("autoStopSpeed")] 		public CFloat AutoStopSpeed { get; set;}

		[Ordinal(6)] [RED("resetDampingAfterStop")] 		public CBool ResetDampingAfterStop { get; set;}

		[Ordinal(7)] [RED("forceWakeUpOnAttach")] 		public CBool ForceWakeUpOnAttach { get; set;}

		[Ordinal(8)] [RED("customDynamicGroup")] 		public CPhysicalCollision CustomDynamicGroup { get; set;}

		[Ordinal(9)] [RED("disableConstrainsTwistAxis")] 		public CBool DisableConstrainsTwistAxis { get; set;}

		[Ordinal(10)] [RED("disableConstrainsSwing1Axis")] 		public CBool DisableConstrainsSwing1Axis { get; set;}

		[Ordinal(11)] [RED("disableConstrainsSwing2Axis")] 		public CBool DisableConstrainsSwing2Axis { get; set;}

		[Ordinal(12)] [RED("jointBounce")] 		public CFloat JointBounce { get; set;}

		[Ordinal(13)] [RED("modifyTwistLower")] 		public CFloat ModifyTwistLower { get; set;}

		[Ordinal(14)] [RED("modifyTwistUpper")] 		public CFloat ModifyTwistUpper { get; set;}

		[Ordinal(15)] [RED("modifySwingY")] 		public CFloat ModifySwingY { get; set;}

		[Ordinal(16)] [RED("modifySwingZ")] 		public CFloat ModifySwingZ { get; set;}

		[Ordinal(17)] [RED("projectionIterations")] 		public CInt32 ProjectionIterations { get; set;}

		public CRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CRagdoll(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}