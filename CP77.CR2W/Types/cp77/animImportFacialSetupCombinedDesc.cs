using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animImportFacialSetupCombinedDesc : CVariable
	{
		[Ordinal(0)]  [RED("eyes")] public animImportFacialSetupDesc Eyes { get; set; }
		[Ordinal(1)]  [RED("face")] public animImportFacialSetupDesc Face { get; set; }
		[Ordinal(2)]  [RED("firstLipsyncOverrideTrackIndex")] public CInt16 FirstLipsyncOverrideTrackIndex { get; set; }
		[Ordinal(3)]  [RED("lipsyncOverrideToMainPosesTracksMapping")] public CArray<CInt16> LipsyncOverrideToMainPosesTracksMapping { get; set; }
		[Ordinal(4)]  [RED("tongue")] public animImportFacialSetupDesc Tongue { get; set; }
		[Ordinal(5)]  [RED("usedTransformIndices")] public CArray<CUInt16> UsedTransformIndices { get; set; }

		public animImportFacialSetupCombinedDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
