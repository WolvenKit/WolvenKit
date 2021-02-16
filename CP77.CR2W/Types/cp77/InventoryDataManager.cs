using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryDataManager : IScriptable
	{
		[Ordinal(0)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(1)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(2)] [RED("transactionSystem")] public CHandle<gameTransactionSystem> TransactionSystem { get; set; }
		[Ordinal(3)] [RED("equipmentSystem")] public CHandle<EquipmentSystem> EquipmentSystem { get; set; }
		[Ordinal(4)] [RED("statsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }
		[Ordinal(5)] [RED("locMgr")] public CHandle<UILocalizationMap> LocMgr { get; set; }

		public InventoryDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
