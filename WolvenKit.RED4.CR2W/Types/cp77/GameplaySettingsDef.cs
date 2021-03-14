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
			get
			{
				if (_disableAutomaticSwitchToVehicleTPP == null)
				{
					_disableAutomaticSwitchToVehicleTPP = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "DisableAutomaticSwitchToVehicleTPP", cr2w, this);
				}
				return _disableAutomaticSwitchToVehicleTPP;
			}
			set
			{
				if (_disableAutomaticSwitchToVehicleTPP == value)
				{
					return;
				}
				_disableAutomaticSwitchToVehicleTPP = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("EnableVehicleToggleSummonMode")] 
		public gamebbScriptID_Bool EnableVehicleToggleSummonMode
		{
			get
			{
				if (_enableVehicleToggleSummonMode == null)
				{
					_enableVehicleToggleSummonMode = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "EnableVehicleToggleSummonMode", cr2w, this);
				}
				return _enableVehicleToggleSummonMode;
			}
			set
			{
				if (_enableVehicleToggleSummonMode == value)
				{
					return;
				}
				_enableVehicleToggleSummonMode = value;
				PropertySet(this);
			}
		}

		public GameplaySettingsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
