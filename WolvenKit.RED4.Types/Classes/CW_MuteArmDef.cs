using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CW_MuteArmDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _muteArmActive;
		private gamebbScriptID_Float _muteArmRadius;

		[Ordinal(0)] 
		[RED("MuteArmActive")] 
		public gamebbScriptID_Bool MuteArmActive
		{
			get => GetProperty(ref _muteArmActive);
			set => SetProperty(ref _muteArmActive, value);
		}

		[Ordinal(1)] 
		[RED("MuteArmRadius")] 
		public gamebbScriptID_Float MuteArmRadius
		{
			get => GetProperty(ref _muteArmRadius);
			set => SetProperty(ref _muteArmRadius, value);
		}
	}
}
