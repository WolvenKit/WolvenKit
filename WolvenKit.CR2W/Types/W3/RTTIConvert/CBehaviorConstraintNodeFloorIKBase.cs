using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintNodeFloorIKBase : CBehaviorGraphPoseConstraintNode
	{
		[RED("requiredAnimEvent")] 		public CName RequiredAnimEvent { get; set;}

		[RED("blockAnimEvent")] 		public CName BlockAnimEvent { get; set;}

		[RED("canBeDisabledDueToFrameRate")] 		public CBool CanBeDisabledDueToFrameRate { get; set;}

		[RED("useFixedVersion")] 		public CBool UseFixedVersion { get; set;}

		[RED("slopeAngleDamp")] 		public CFloat SlopeAngleDamp { get; set;}

		[RED("generateEditorFragmentsForIKSolvers")] 		public CBool GenerateEditorFragmentsForIKSolvers { get; set;}

		[RED("generateEditorFragmentsForLegIndex")] 		public CInt32 GenerateEditorFragmentsForLegIndex { get; set;}

		[RED("common")] 		public SBehaviorConstraintNodeFloorIKCommonData Common { get; set;}

		public CBehaviorConstraintNodeFloorIKBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintNodeFloorIKBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}