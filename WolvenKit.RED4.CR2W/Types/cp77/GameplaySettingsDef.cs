using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySettingsDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _disableAutomaticSwitchToVehicleTPP;
		private gamebbScriptID_Bool _enableVehicleToggleSummonMode;

		[Ordinal(0)] 
		[RED("DisableAutomaticSwitchToVehicleTPP")] 
		public gamebbScriptID_Bool DisableAutomaticSwitchToVehicleTPP
		{
			get => GetProperty(ref _disableAutomaticSwitchToVehicleTPP);
			set => SetProperty(ref _disableAutomaticSwitchToVehicleTPP, value);
		}

		[Ordinal(1)] 
		[RED("EnableVehicleToggleSummonMode")] 
		public gamebbScriptID_Bool EnableVehicleToggleSummonMode
		{
			get => GetProperty(ref _enableVehicleToggleSummonMode);
			set => SetProperty(ref _enableVehicleToggleSummonMode, value);
		}

		public GameplaySettingsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
