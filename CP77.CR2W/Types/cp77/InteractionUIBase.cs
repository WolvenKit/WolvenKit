using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionUIBase : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("InteractionsBlackboard")] public CHandle<gameIBlackboard> InteractionsBlackboard { get; set; }
		[Ordinal(8)]  [RED("InteractionsBBDefinition")] public CHandle<UIInteractionsDef> InteractionsBBDefinition { get; set; }
		[Ordinal(9)]  [RED("DialogsDataListenerId")] public CUInt32 DialogsDataListenerId { get; set; }
		[Ordinal(10)]  [RED("DialogsActiveHubListenerId")] public CUInt32 DialogsActiveHubListenerId { get; set; }
		[Ordinal(11)]  [RED("DialogsSelectedChoiceListenerId")] public CUInt32 DialogsSelectedChoiceListenerId { get; set; }
		[Ordinal(12)]  [RED("InteractionsDataListenerId")] public CUInt32 InteractionsDataListenerId { get; set; }
		[Ordinal(13)]  [RED("lootingDataListenerId")] public CUInt32 LootingDataListenerId { get; set; }
		[Ordinal(14)]  [RED("AreDialogsOpen")] public CBool AreDialogsOpen { get; set; }
		[Ordinal(15)]  [RED("AreContactsOpen")] public CBool AreContactsOpen { get; set; }
		[Ordinal(16)]  [RED("IsLootingOpen")] public CBool IsLootingOpen { get; set; }
		[Ordinal(17)]  [RED("AreInteractionsOpen")] public CBool AreInteractionsOpen { get; set; }
		[Ordinal(18)]  [RED("interactionIsScrollable")] public CBool InteractionIsScrollable { get; set; }
		[Ordinal(19)]  [RED("dialogIsScrollable")] public CBool DialogIsScrollable { get; set; }
		[Ordinal(20)]  [RED("lootingIsScrollable")] public CBool LootingIsScrollable { get; set; }

		public InteractionUIBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
