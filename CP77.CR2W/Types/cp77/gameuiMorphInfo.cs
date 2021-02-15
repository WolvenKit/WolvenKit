using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMorphInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(12)] [RED("morphNames")] public CArray<gameuiIndexedMorphName> MorphNames { get; set; }

		public gameuiMorphInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
