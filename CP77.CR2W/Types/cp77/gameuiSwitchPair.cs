using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitchPair : CVariable
	{
		[Ordinal(0)]  [RED("currOption")] public wCHandle<gameuiCharacterCustomizationOption> CurrOption { get; set; }
		[Ordinal(1)]  [RED("prevOption")] public wCHandle<gameuiCharacterCustomizationOption> PrevOption { get; set; }

		public gameuiSwitchPair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
