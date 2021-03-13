using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent : redEvent
	{
		[Ordinal(0)] [RED("option")] public wCHandle<gameuiCharacterCustomizationOption> Option { get; set; }

		public gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
