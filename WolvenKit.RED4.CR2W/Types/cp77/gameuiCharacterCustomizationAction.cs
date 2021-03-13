using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationAction : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gameuiCharacterCustomizationActionType> Type { get; set; }
		[Ordinal(1)] [RED("params")] public CString Params { get; set; }

		public gameuiCharacterCustomizationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
