using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_TracksMapping : CVariable
	{
		[Ordinal(0)]  [RED("numEnvelopes")] public CUInt16 NumEnvelopes { get; set; }
		[Ordinal(1)]  [RED("numLipsyncOverrides")] public CUInt16 NumLipsyncOverrides { get; set; }
		[Ordinal(2)]  [RED("numMainPoses")] public CUInt16 NumMainPoses { get; set; }
		[Ordinal(3)]  [RED("numWrinkles")] public CUInt16 NumWrinkles { get; set; }

		public animFacialSetup_TracksMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
