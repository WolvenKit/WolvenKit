using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animFacialCustomizationSet : CResource
	{
		[Ordinal(0)]  [RED("baseSetup")] public rRef<animFacialSetup> BaseSetup { get; set; }
		[Ordinal(1)]  [RED("correctivePosesData")] public DataBuffer CorrectivePosesData { get; set; }
		[Ordinal(2)]  [RED("isCooked")] public CBool IsCooked { get; set; }
		[Ordinal(3)]  [RED("jointRegions")] public CArray<CUInt8> JointRegions { get; set; }
		[Ordinal(4)]  [RED("mainPosesData")] public DataBuffer MainPosesData { get; set; }
		[Ordinal(5)]  [RED("numJoints")] public CUInt32 NumJoints { get; set; }
		[Ordinal(6)]  [RED("numTargets")] public CUInt32 NumTargets { get; set; }
		[Ordinal(7)]  [RED("posesInfo")] public animFacialSetup_PosesBufferInfo PosesInfo { get; set; }
		[Ordinal(8)]  [RED("rigReferencePosesData")] public DataBuffer RigReferencePosesData { get; set; }
		[Ordinal(9)]  [RED("targetSetups")] public CArray<raRef<animFacialSetup>> TargetSetups { get; set; }
		[Ordinal(10)]  [RED("targetSetupsTemp")] public CArray<animFacialCustomizationTargetEntryTemp> TargetSetupsTemp { get; set; }
		[Ordinal(11)]  [RED("usedTransformIndices")] public CArray<CUInt16> UsedTransformIndices { get; set; }

		public animFacialCustomizationSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
