using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DebugHubMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("menuCtrl")] public wCHandle<DebugHubMenuLogicController> MenuCtrl { get; set; }
		[Ordinal(4)] [RED("selectorCtrl")] public wCHandle<hubSelectorController> SelectorCtrl { get; set; }
		[Ordinal(5)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(6)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(7)] [RED("PDS")] public CHandle<PlayerDevelopmentSystem> PDS { get; set; }
		[Ordinal(8)] [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(9)] [RED("currencyListener")] public CUInt32 CurrencyListener { get; set; }
		[Ordinal(10)] [RED("characterCredListener")] public CUInt32 CharacterCredListener { get; set; }
		[Ordinal(11)] [RED("characterLevelListener")] public CUInt32 CharacterLevelListener { get; set; }
		[Ordinal(12)] [RED("characterCurrentXPListener")] public CUInt32 CharacterCurrentXPListener { get; set; }
		[Ordinal(13)] [RED("characterCredPointsListener")] public CUInt32 CharacterCredPointsListener { get; set; }
		[Ordinal(14)] [RED("Transaction")] public CHandle<gameTransactionSystem> Transaction { get; set; }

		public DebugHubMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
