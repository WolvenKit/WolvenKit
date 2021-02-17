using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionUIBase : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("InteractionsBlackboard")] public CHandle<gameIBlackboard> InteractionsBlackboard { get; set; }
		[Ordinal(10)] [RED("InteractionsBBDefinition")] public CHandle<UIInteractionsDef> InteractionsBBDefinition { get; set; }
		[Ordinal(11)] [RED("DialogsDataListenerId")] public CUInt32 DialogsDataListenerId { get; set; }
		[Ordinal(12)] [RED("DialogsActiveHubListenerId")] public CUInt32 DialogsActiveHubListenerId { get; set; }
		[Ordinal(13)] [RED("DialogsSelectedChoiceListenerId")] public CUInt32 DialogsSelectedChoiceListenerId { get; set; }
		[Ordinal(14)] [RED("InteractionsDataListenerId")] public CUInt32 InteractionsDataListenerId { get; set; }
		[Ordinal(15)] [RED("lootingDataListenerId")] public CUInt32 LootingDataListenerId { get; set; }
		[Ordinal(16)] [RED("AreDialogsOpen")] public CBool AreDialogsOpen { get; set; }
		[Ordinal(17)] [RED("AreContactsOpen")] public CBool AreContactsOpen { get; set; }
		[Ordinal(18)] [RED("IsLootingOpen")] public CBool IsLootingOpen { get; set; }
		[Ordinal(19)] [RED("AreInteractionsOpen")] public CBool AreInteractionsOpen { get; set; }
		[Ordinal(20)] [RED("interactionIsScrollable")] public CBool InteractionIsScrollable { get; set; }
		[Ordinal(21)] [RED("dialogIsScrollable")] public CBool DialogIsScrollable { get; set; }
		[Ordinal(22)] [RED("lootingIsScrollable")] public CBool LootingIsScrollable { get; set; }

		public InteractionUIBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
