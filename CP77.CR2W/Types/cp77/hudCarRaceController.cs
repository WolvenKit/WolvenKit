using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class hudCarRaceController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("Countdown")] public inkCanvasWidgetReference Countdown { get; set; }
		[Ordinal(1)]  [RED("PositionCounter")] public inkCanvasWidgetReference PositionCounter { get; set; }
		[Ordinal(2)]  [RED("RaceCheckpoint")] public inkTextWidgetReference RaceCheckpoint { get; set; }
		[Ordinal(3)]  [RED("RacePosition")] public inkTextWidgetReference RacePosition { get; set; }
		[Ordinal(4)]  [RED("RaceTime")] public inkTextWidgetReference RaceTime { get; set; }
		[Ordinal(5)]  [RED("activeVehicle")] public wCHandle<vehicleBaseObject> ActiveVehicle { get; set; }
		[Ordinal(6)]  [RED("activeVehicleUIBlackboard")] public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard { get; set; }
		[Ordinal(7)]  [RED("factCallbackID")] public CUInt32 FactCallbackID { get; set; }
		[Ordinal(8)]  [RED("maxCheckpoint")] public CInt32 MaxCheckpoint { get; set; }
		[Ordinal(9)]  [RED("maxPosition")] public CInt32 MaxPosition { get; set; }
		[Ordinal(10)]  [RED("minute")] public CInt32 Minute { get; set; }
		[Ordinal(11)]  [RED("playerPosition")] public CInt32 PlayerPosition { get; set; }
		[Ordinal(12)]  [RED("raceStartEngineTime")] public EngineTime RaceStartEngineTime { get; set; }

		public hudCarRaceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
