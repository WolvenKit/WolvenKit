using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("BikeTilt")] public gamebbScriptID_Float BikeTilt { get; set; }
		[Ordinal(1)] [RED("SpeedValue")] public gamebbScriptID_Float SpeedValue { get; set; }
		[Ordinal(2)] [RED("GearValue")] public gamebbScriptID_Int32 GearValue { get; set; }
		[Ordinal(3)] [RED("RPMValue")] public gamebbScriptID_Float RPMValue { get; set; }
		[Ordinal(4)] [RED("RPMMax")] public gamebbScriptID_Float RPMMax { get; set; }
		[Ordinal(5)] [RED("SuspensionTransversalForce")] public gamebbScriptID_Float SuspensionTransversalForce { get; set; }
		[Ordinal(6)] [RED("SuspensionLongitudinalForce")] public gamebbScriptID_Float SuspensionLongitudinalForce { get; set; }
		[Ordinal(7)] [RED("IsAutopilotOn")] public gamebbScriptID_Bool IsAutopilotOn { get; set; }
		[Ordinal(8)] [RED("DeclutchTimer")] public gamebbScriptID_Float DeclutchTimer { get; set; }
		[Ordinal(9)] [RED("HandlingPenalty")] public gamebbScriptID_Float HandlingPenalty { get; set; }
		[Ordinal(10)] [RED("LightMode")] public gamebbScriptID_Int32 LightMode { get; set; }
		[Ordinal(11)] [RED("VehicleState")] public gamebbScriptID_Int32 VehicleState { get; set; }
		[Ordinal(12)] [RED("VehicleReady")] public gamebbScriptID_Bool VehicleReady { get; set; }
		[Ordinal(13)] [RED("VehRadioState")] public gamebbScriptID_Bool VehRadioState { get; set; }
		[Ordinal(14)] [RED("VehRadioStationName")] public gamebbScriptID_CName VehRadioStationName { get; set; }
		[Ordinal(15)] [RED("IsCrowd")] public gamebbScriptID_Bool IsCrowd { get; set; }
		[Ordinal(16)] [RED("IsUIActive")] public gamebbScriptID_Bool IsUIActive { get; set; }
		[Ordinal(17)] [RED("GameTime")] public gamebbScriptID_String GameTime { get; set; }
		[Ordinal(18)] [RED("Collision")] public gamebbScriptID_Bool Collision { get; set; }
		[Ordinal(19)] [RED("DamageState")] public gamebbScriptID_Int32 DamageState { get; set; }
		[Ordinal(20)] [RED("MeanSlipRatio")] public gamebbScriptID_Float MeanSlipRatio { get; set; }
		[Ordinal(21)] [RED("IsHandbraking")] public gamebbScriptID_Int32 IsHandbraking { get; set; }
		[Ordinal(22)] [RED("EngineTemp")] public gamebbScriptID_Float EngineTemp { get; set; }
		[Ordinal(23)] [RED("IsInWater")] public gamebbScriptID_Bool IsInWater { get; set; }
		[Ordinal(24)] [RED("RaceTimer")] public gamebbScriptID_String RaceTimer { get; set; }
		[Ordinal(25)] [RED("IsTargetingFriendly")] public gamebbScriptID_Bool IsTargetingFriendly { get; set; }

		public VehicleDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
