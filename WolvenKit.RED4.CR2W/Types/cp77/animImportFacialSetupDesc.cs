using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialSetupDesc : CVariable
	{
		[Ordinal(0)] [RED("initialPose")] public CArray<animImportFacialInitialPoseEntryDesc> InitialPose { get; set; }
		[Ordinal(1)] [RED("initialControls")] public animImportFacialInitialControlsDesc InitialControls { get; set; }
		[Ordinal(2)] [RED("mainPoses")] public CArray<animImportFacialMainPoseDesc> MainPoses { get; set; }
		[Ordinal(3)] [RED("mainPosesInfo")] public CArray<animSermoPoseInfo> MainPosesInfo { get; set; }
		[Ordinal(4)] [RED("jawAreaTrackIndices")] public CArray<CInt16> JawAreaTrackIndices { get; set; }
		[Ordinal(5)] [RED("lipsAreaTrackIndices")] public CArray<CInt16> LipsAreaTrackIndices { get; set; }
		[Ordinal(6)] [RED("eyesAreaTrackIndices")] public CArray<CInt16> EyesAreaTrackIndices { get; set; }
		[Ordinal(7)] [RED("numCachedPoseTracks")] public CUInt16 NumCachedPoseTracks { get; set; }
		[Ordinal(8)] [RED("correctivePoses")] public CArray<animImportFacialCorrectivePoseDesc> CorrectivePoses { get; set; }
		[Ordinal(9)] [RED("globalPoseLimits")] public CArray<animPoseLimitWeights> GlobalPoseLimits { get; set; }
		[Ordinal(10)] [RED("wrinkleStartingIndex")] public CUInt16 WrinkleStartingIndex { get; set; }
		[Ordinal(11)] [RED("wrinkleMapping")] public CArray<CUInt16> WrinkleMapping { get; set; }

		public animImportFacialSetupDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
