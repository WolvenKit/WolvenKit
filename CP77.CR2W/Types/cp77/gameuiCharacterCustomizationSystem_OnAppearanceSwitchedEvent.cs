using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent : redEvent
	{
		[Ordinal(0)]  [RED("pairs")] public CArray<gameuiSwitchPair> Pairs { get; set; }

		public gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
