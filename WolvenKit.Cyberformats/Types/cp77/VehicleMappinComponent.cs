using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleMappinComponent : IScriptable
	{
		[Ordinal(0)] [RED("questMappinController")] public wCHandle<QuestMappinController> QuestMappinController { get; set; }
		[Ordinal(1)] [RED("vehicleMappin")] public wCHandle<gamemappinsVehicleMappin> VehicleMappin { get; set; }
		[Ordinal(2)] [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }
		[Ordinal(3)] [RED("vehicleEntityID")] public entEntityID VehicleEntityID { get; set; }
		[Ordinal(4)] [RED("playerMounted")] public CBool PlayerMounted { get; set; }
		[Ordinal(5)] [RED("vehicleEnRoute")] public CBool VehicleEnRoute { get; set; }
		[Ordinal(6)] [RED("scheduleDiscreteModeDelayID")] public gameDelayID ScheduleDiscreteModeDelayID { get; set; }
		[Ordinal(7)] [RED("invalidDelayID")] public gameDelayID InvalidDelayID { get; set; }
		[Ordinal(8)] [RED("init")] public CBool Init { get; set; }
		[Ordinal(9)] [RED("vehicleSummonDataDef")] public CHandle<VehicleSummonDataDef> VehicleSummonDataDef { get; set; }
		[Ordinal(10)] [RED("vehicleSummonDataBB")] public CHandle<gameIBlackboard> VehicleSummonDataBB { get; set; }
		[Ordinal(11)] [RED("vehicleSummonStateCallback")] public CUInt32 VehicleSummonStateCallback { get; set; }
		[Ordinal(12)] [RED("uiActiveVehicleDataDef")] public CHandle<UI_ActiveVehicleDataDef> UiActiveVehicleDataDef { get; set; }
		[Ordinal(13)] [RED("uiActiveVehicleDataBB")] public CHandle<gameIBlackboard> UiActiveVehicleDataBB { get; set; }
		[Ordinal(14)] [RED("vehPlayerStateDataCallback")] public CUInt32 VehPlayerStateDataCallback { get; set; }

		public VehicleMappinComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
