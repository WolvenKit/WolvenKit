using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent : redEvent
	{
		[Ordinal(0)] [RED("option")] public wCHandle<gameuiCharacterCustomizationOption> Option { get; set; }

		public gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
