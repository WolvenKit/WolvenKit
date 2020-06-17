using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintNodeFloorIKLegsData : CVariable
	{
		[RED("Min rel offset")] 		public CFloat Min_rel_offset { get; set;}

		[RED("Max rel offset")] 		public CFloat Max_rel_offset { get; set;}

		[RED("Min trace offset")] 		public CFloat Min_trace_offset { get; set;}

		[RED("Max trace offset")] 		public CFloat Max_trace_offset { get; set;}

		[RED("verticalOffsetBlendUpTime")] 		public CFloat VerticalOffsetBlendUpTime { get; set;}

		[RED("verticalOffsetBlendDownTime")] 		public CFloat VerticalOffsetBlendDownTime { get; set;}

		[RED("Max distance for trace update")] 		public CFloat Max_distance_for_trace_update { get; set;}

		[RED("maxAngleOffUprightNormal")] 		public CFloat MaxAngleOffUprightNormal { get; set;}

		[RED("maxAngleOffUprightNormalSide")] 		public CFloat MaxAngleOffUprightNormalSide { get; set;}

		[RED("maxAngleOffUprightNormalToRevert")] 		public CFloat MaxAngleOffUprightNormalToRevert { get; set;}

		public SBehaviorConstraintNodeFloorIKLegsData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBehaviorConstraintNodeFloorIKLegsData(cr2w);

	}
}