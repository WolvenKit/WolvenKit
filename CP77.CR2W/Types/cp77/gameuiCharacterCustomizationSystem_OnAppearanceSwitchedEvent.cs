using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent : redEvent
	{
		[Ordinal(0)]  [RED("pairs")] public CArray<gameuiSwitchPair> Pairs { get; set; }

		public gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
