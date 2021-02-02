using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_OneSermoBufferInfo : CVariable
	{
		[Ordinal(0)]  [RED("numGlobalLimits")] public CUInt16 NumGlobalLimits { get; set; }
		[Ordinal(1)]  [RED("numInfluencedPoses")] public CUInt16 NumInfluencedPoses { get; set; }
		[Ordinal(2)]  [RED("numInfluenceIndices")] public CUInt16 NumInfluenceIndices { get; set; }
		[Ordinal(3)]  [RED("numUpperLowerFace")] public CUInt16 NumUpperLowerFace { get; set; }
		[Ordinal(4)]  [RED("numLipsyncPosesSides")] public CUInt16 NumLipsyncPosesSides { get; set; }
		[Ordinal(5)]  [RED("numAllCorrectives")] public CUInt16 NumAllCorrectives { get; set; }
		[Ordinal(6)]  [RED("numGlobalCorrectiveEntries")] public CUInt16 NumGlobalCorrectiveEntries { get; set; }
		[Ordinal(7)]  [RED("numInbetweenCorrectiveEntries")] public CUInt16 NumInbetweenCorrectiveEntries { get; set; }
		[Ordinal(8)]  [RED("numCorrectiveInfluencedPoses")] public CUInt16 NumCorrectiveInfluencedPoses { get; set; }
		[Ordinal(9)]  [RED("numCorrectiveInfluenceIndices")] public CUInt16 NumCorrectiveInfluenceIndices { get; set; }
		[Ordinal(10)]  [RED("numAllMainPoses")] public CUInt16 NumAllMainPoses { get; set; }
		[Ordinal(11)]  [RED("numAllMainPosesInbetweens")] public CUInt16 NumAllMainPosesInbetweens { get; set; }
		[Ordinal(12)]  [RED("numAllMainPosesInbetweenScopeMultipliers")] public CUInt16 NumAllMainPosesInbetweenScopeMultipliers { get; set; }
		[Ordinal(13)]  [RED("numEnvelopesPerTrackMapping")] public CUInt16 NumEnvelopesPerTrackMapping { get; set; }
		[Ordinal(14)]  [RED("wrinkleStartingIndex")] public CUInt16 WrinkleStartingIndex { get; set; }
		[Ordinal(15)]  [RED("numWrinkles")] public CUInt16 NumWrinkles { get; set; }

		public animFacialSetup_OneSermoBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
