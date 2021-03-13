using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySettingsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("DisableAutomaticSwitchToVehicleTPP")] public gamebbScriptID_Bool DisableAutomaticSwitchToVehicleTPP { get; set; }
		[Ordinal(1)] [RED("EnableVehicleToggleSummonMode")] public gamebbScriptID_Bool EnableVehicleToggleSummonMode { get; set; }

		public GameplaySettingsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
