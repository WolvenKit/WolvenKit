using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationAttribute : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gamedataStatType> Type { get; set; }
		[Ordinal(1)] [RED("value")] public CUInt32 Value { get; set; }

		public gameuiCharacterCustomizationAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
