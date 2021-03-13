using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemsNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] [RED("showDuration")] public CFloat ShowDuration { get; set; }
		[Ordinal(3)] [RED("transactionSystem")] public wCHandle<gameTransactionSystem> TransactionSystem { get; set; }
		[Ordinal(4)] [RED("currencyNotification")] public CName CurrencyNotification { get; set; }
		[Ordinal(5)] [RED("itemNotification")] public CName ItemNotification { get; set; }
		[Ordinal(6)] [RED("xpNotification")] public CName XpNotification { get; set; }
		[Ordinal(7)] [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(8)] [RED("inventoryListener")] public wCHandle<gameInventoryScriptListener> InventoryListener { get; set; }
		[Ordinal(9)] [RED("currencyInventoryListener")] public wCHandle<gameInventoryScriptListener> CurrencyInventoryListener { get; set; }
		[Ordinal(10)] [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(11)] [RED("playerDevelopmentSystem")] public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem { get; set; }
		[Ordinal(12)] [RED("combatModeListener")] public CUInt32 CombatModeListener { get; set; }
		[Ordinal(13)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(14)] [RED("comparisonResolver")] public CHandle<ItemPreferredComparisonResolver> ComparisonResolver { get; set; }
		[Ordinal(15)] [RED("combatModePSM")] public CEnum<gamePSMCombat> CombatModePSM { get; set; }

		public ItemsNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
