using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitchPair : CVariable
	{
		[Ordinal(0)] [RED("prevOption")] public wCHandle<gameuiCharacterCustomizationOption> PrevOption { get; set; }
		[Ordinal(1)] [RED("currOption")] public wCHandle<gameuiCharacterCustomizationOption> CurrOption { get; set; }

		public gameuiSwitchPair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
