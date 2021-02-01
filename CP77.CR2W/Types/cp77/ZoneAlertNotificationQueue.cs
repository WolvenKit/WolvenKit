using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ZoneAlertNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(0)]  [RED("WANTED_TIER_SIZE")] public CInt32 WANTED_TIER_SIZE { get; set; }
		[Ordinal(1)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(2)]  [RED("bountyAmountBlackboardID")] public CUInt32 BountyAmountBlackboardID { get; set; }
		[Ordinal(3)]  [RED("bountyPrice")] public CInt32 BountyPrice { get; set; }
		[Ordinal(4)]  [RED("combatBlackBoardID")] public CUInt32 CombatBlackBoardID { get; set; }
		[Ordinal(5)]  [RED("currentSecurityZoneType")] public CEnum<ESecurityAreaType> CurrentSecurityZoneType { get; set; }
		[Ordinal(6)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(7)]  [RED("factListenerID")] public CUInt32 FactListenerID { get; set; }
		[Ordinal(8)]  [RED("playerBlackboardID")] public CUInt32 PlayerBlackboardID { get; set; }
		[Ordinal(9)]  [RED("playerInCombat")] public CBool PlayerInCombat { get; set; }
		[Ordinal(10)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(11)]  [RED("securityBlackBoardID")] public CUInt32 SecurityBlackBoardID { get; set; }
		[Ordinal(12)]  [RED("vehicleZoneBlackboard")] public CHandle<gameIBlackboard> VehicleZoneBlackboard { get; set; }
		[Ordinal(13)]  [RED("vehicleZoneBlackboardDef")] public CHandle<LocalPlayerDef> VehicleZoneBlackboardDef { get; set; }
		[Ordinal(14)]  [RED("vehicleZoneBlackboardID")] public CUInt32 VehicleZoneBlackboardID { get; set; }
		[Ordinal(15)]  [RED("wantedBlackboard")] public CHandle<gameIBlackboard> WantedBlackboard { get; set; }
		[Ordinal(16)]  [RED("wantedBlackboardDef")] public CHandle<UI_WantedBarDef> WantedBlackboardDef { get; set; }
		[Ordinal(17)]  [RED("wantedLevel")] public CInt32 WantedLevel { get; set; }
		[Ordinal(18)]  [RED("wantedValueBlackboardID")] public CUInt32 WantedValueBlackboardID { get; set; }

		public ZoneAlertNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
