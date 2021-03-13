using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDropItemEvent : redEvent
	{
		[Ordinal(0)] [RED("slotId")] public TweakDBID SlotId { get; set; }

		public gameeventsDropItemEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
