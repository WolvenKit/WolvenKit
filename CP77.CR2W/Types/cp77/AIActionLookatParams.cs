using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIActionLookatParams : CVariable
	{
		[Ordinal(0)] [RED("useLookat")] public CBool UseLookat { get; set; }
		[Ordinal(1)] [RED("useLeftHand")] public CBool UseLeftHand { get; set; }
		[Ordinal(2)] [RED("useRightHand")] public CBool UseRightHand { get; set; }
		[Ordinal(3)] [RED("attachRightHandtoLeftHand")] public CBool AttachRightHandtoLeftHand { get; set; }
		[Ordinal(4)] [RED("attachLeftHandtoRightHand")] public CBool AttachLeftHandtoRightHand { get; set; }
		[Ordinal(5)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(6)] [RED("lookatStyle")] public CEnum<animLookAtStyle> LookatStyle { get; set; }
		[Ordinal(7)] [RED("hasOutTransition")] public CBool HasOutTransition { get; set; }
		[Ordinal(8)] [RED("outTransitionStyle")] public CEnum<animLookAtStyle> OutTransitionStyle { get; set; }
		[Ordinal(9)] [RED("softLimitDegrees")] public CEnum<animLookAtLimitDegreesType> SoftLimitDegrees { get; set; }
		[Ordinal(10)] [RED("hardLimitDegrees")] public CEnum<animLookAtLimitDegreesType> HardLimitDegrees { get; set; }
		[Ordinal(11)] [RED("hardLimitDistance")] public CEnum<animLookAtLimitDistanceType> HardLimitDistance { get; set; }
		[Ordinal(12)] [RED("backLimitDegrees")] public CEnum<animLookAtLimitDegreesType> BackLimitDegrees { get; set; }
		[Ordinal(13)] [RED("additionalParts")] public CArray<animLookAtPartRequest> AdditionalParts { get; set; }

		public AIActionLookatParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
