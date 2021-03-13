using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootPickupDelayEvent : redEvent
	{
		[Ordinal(0)] [RED("enableLootInteraction")] public CBool EnableLootInteraction { get; set; }

		public LootPickupDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
