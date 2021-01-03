using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animImportFacialSetupDesc : CVariable
	{
		[Ordinal(0)]  [RED("correctivePoses")] public CArray<animImportFacialCorrectivePoseDesc> CorrectivePoses { get; set; }
		[Ordinal(1)]  [RED("eyesAreaTrackIndices")] public CArray<CInt16> EyesAreaTrackIndices { get; set; }
		[Ordinal(2)]  [RED("globalPoseLimits")] public CArray<animPoseLimitWeights> GlobalPoseLimits { get; set; }
		[Ordinal(3)]  [RED("initialControls")] public animImportFacialInitialControlsDesc InitialControls { get; set; }
		[Ordinal(4)]  [RED("initialPose")] public CArray<animImportFacialInitialPoseEntryDesc> InitialPose { get; set; }
		[Ordinal(5)]  [RED("jawAreaTrackIndices")] public CArray<CInt16> JawAreaTrackIndices { get; set; }
		[Ordinal(6)]  [RED("lipsAreaTrackIndices")] public CArray<CInt16> LipsAreaTrackIndices { get; set; }
		[Ordinal(7)]  [RED("mainPoses")] public CArray<animImportFacialMainPoseDesc> MainPoses { get; set; }
		[Ordinal(8)]  [RED("mainPosesInfo")] public CArray<animSermoPoseInfo> MainPosesInfo { get; set; }
		[Ordinal(9)]  [RED("numCachedPoseTracks")] public CUInt16 NumCachedPoseTracks { get; set; }
		[Ordinal(10)]  [RED("wrinkleMapping")] public CArray<CUInt16> WrinkleMapping { get; set; }
		[Ordinal(11)]  [RED("wrinkleStartingIndex")] public CUInt16 WrinkleStartingIndex { get; set; }

		public animImportFacialSetupDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
