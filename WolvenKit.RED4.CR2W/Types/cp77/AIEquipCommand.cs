using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIEquipCommand : AICommand
	{
		[Ordinal(4)] [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(5)] [RED("itemId")] public TweakDBID ItemId { get; set; }
		[Ordinal(6)] [RED("failIfItemNotFound")] public CBool FailIfItemNotFound { get; set; }
		[Ordinal(7)] [RED("durationOverride")] public CFloat DurationOverride { get; set; }

		public AIEquipCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
