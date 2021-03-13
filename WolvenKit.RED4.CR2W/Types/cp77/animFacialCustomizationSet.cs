using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialCustomizationSet : CResource
	{
		[Ordinal(1)] [RED("baseSetup")] public rRef<animFacialSetup> BaseSetup { get; set; }
		[Ordinal(2)] [RED("targetSetups")] public CArray<raRef<animFacialSetup>> TargetSetups { get; set; }
		[Ordinal(3)] [RED("targetSetupsTemp")] public CArray<animFacialCustomizationTargetEntryTemp> TargetSetupsTemp { get; set; }
		[Ordinal(4)] [RED("numTargets")] public CUInt32 NumTargets { get; set; }
		[Ordinal(5)] [RED("posesInfo")] public animFacialSetup_PosesBufferInfo PosesInfo { get; set; }
		[Ordinal(6)] [RED("jointRegions")] public CArray<CUInt8> JointRegions { get; set; }
		[Ordinal(7)] [RED("mainPosesData")] public DataBuffer MainPosesData { get; set; }
		[Ordinal(8)] [RED("usedTransformIndices")] public CArray<CUInt16> UsedTransformIndices { get; set; }
		[Ordinal(9)] [RED("correctivePosesData")] public DataBuffer CorrectivePosesData { get; set; }
		[Ordinal(10)] [RED("numJoints")] public CUInt32 NumJoints { get; set; }
		[Ordinal(11)] [RED("rigReferencePosesData")] public DataBuffer RigReferencePosesData { get; set; }
		[Ordinal(12)] [RED("isCooked")] public CBool IsCooked { get; set; }

		public animFacialCustomizationSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
