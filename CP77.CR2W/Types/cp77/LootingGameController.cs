using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LootingGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("activeHubListenerId")] public CUInt32 ActiveHubListenerId { get; set; }
		[Ordinal(1)]  [RED("activeListenerId")] public CUInt32 ActiveListenerId { get; set; }
		[Ordinal(2)]  [RED("bbEquipmentData")] public CHandle<gameIBlackboard> BbEquipmentData { get; set; }
		[Ordinal(3)]  [RED("bbEquipmentDefinition")] public CHandle<UI_EquipmentDataDef> BbEquipmentDefinition { get; set; }
		[Ordinal(4)]  [RED("bbInteractions")] public CHandle<gameIBlackboard> BbInteractions { get; set; }
		[Ordinal(5)]  [RED("bbInteractionsDefinition")] public CHandle<UIInteractionsDef> BbInteractionsDefinition { get; set; }
		[Ordinal(6)]  [RED("controller")] public CHandle<LootingController> Controller { get; set; }
		[Ordinal(7)]  [RED("dataListenerId")] public CUInt32 DataListenerId { get; set; }
		[Ordinal(8)]  [RED("dataManager")] public CHandle<InventoryDataManagerV2> DataManager { get; set; }
		[Ordinal(9)]  [RED("introAnim")] public CHandle<inkanimProxy> IntroAnim { get; set; }
		[Ordinal(10)]  [RED("lastActiveWeapon")] public gameSlotWeaponData LastActiveWeapon { get; set; }
		[Ordinal(11)]  [RED("lastActiveWeaponData")] public InventoryItemData LastActiveWeaponData { get; set; }
		[Ordinal(12)]  [RED("outroAnim")] public CHandle<inkanimProxy> OutroAnim { get; set; }
		[Ordinal(13)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(14)]  [RED("previousData")] public gameinteractionsvisLootData PreviousData { get; set; }
		[Ordinal(15)]  [RED("weaponDataListenerId")] public CUInt32 WeaponDataListenerId { get; set; }

		public LootingGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
