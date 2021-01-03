using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationAction : CVariable
	{
		[Ordinal(0)]  [RED("params")] public CString Params { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<gameuiCharacterCustomizationActionType> Type { get; set; }

		public gameuiCharacterCustomizationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
