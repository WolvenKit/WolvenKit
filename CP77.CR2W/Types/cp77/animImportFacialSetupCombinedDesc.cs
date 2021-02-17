using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animImportFacialSetupCombinedDesc : CVariable
	{
		[Ordinal(0)] [RED("face")] public animImportFacialSetupDesc Face { get; set; }
		[Ordinal(1)] [RED("eyes")] public animImportFacialSetupDesc Eyes { get; set; }
		[Ordinal(2)] [RED("tongue")] public animImportFacialSetupDesc Tongue { get; set; }
		[Ordinal(3)] [RED("usedTransformIndices")] public CArray<CUInt16> UsedTransformIndices { get; set; }
		[Ordinal(4)] [RED("lipsyncOverrideToMainPosesTracksMapping")] public CArray<CInt16> LipsyncOverrideToMainPosesTracksMapping { get; set; }
		[Ordinal(5)] [RED("firstLipsyncOverrideTrackIndex")] public CInt16 FirstLipsyncOverrideTrackIndex { get; set; }

		public animImportFacialSetupCombinedDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
