using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintNodeFloorIKLegsData : CVariable
	{
		[Ordinal(1)] [RED("Min rel offset")] 		public CFloat Min_rel_offset { get; set;}

		[Ordinal(2)] [RED("Max rel offset")] 		public CFloat Max_rel_offset { get; set;}

		[Ordinal(3)] [RED("Min trace offset")] 		public CFloat Min_trace_offset { get; set;}

		[Ordinal(4)] [RED("Max trace offset")] 		public CFloat Max_trace_offset { get; set;}

		[Ordinal(5)] [RED("verticalOffsetBlendUpTime")] 		public CFloat VerticalOffsetBlendUpTime { get; set;}

		[Ordinal(6)] [RED("verticalOffsetBlendDownTime")] 		public CFloat VerticalOffsetBlendDownTime { get; set;}

		[Ordinal(7)] [RED("Max distance for trace update")] 		public CFloat Max_distance_for_trace_update { get; set;}

		[Ordinal(8)] [RED("maxAngleOffUprightNormal")] 		public CFloat MaxAngleOffUprightNormal { get; set;}

		[Ordinal(9)] [RED("maxAngleOffUprightNormalSide")] 		public CFloat MaxAngleOffUprightNormalSide { get; set;}

		[Ordinal(10)] [RED("maxAngleOffUprightNormalToRevert")] 		public CFloat MaxAngleOffUprightNormalToRevert { get; set;}

		public SBehaviorConstraintNodeFloorIKLegsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorConstraintNodeFloorIKLegsData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}