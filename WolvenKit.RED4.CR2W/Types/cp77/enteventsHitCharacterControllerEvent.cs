using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsHitCharacterControllerEvent : redEvent
	{
		[Ordinal(0)] [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(1)] [RED("component")] public wCHandle<entIComponent> Component { get; set; }

		public enteventsHitCharacterControllerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
