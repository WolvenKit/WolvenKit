using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnVoicesetComponent : gameComponent
	{
		private CName _combatVoSettingsName;

		[Ordinal(4)] 
		[RED("combatVoSettingsName")] 
		public CName CombatVoSettingsName
		{
			get => GetProperty(ref _combatVoSettingsName);
			set => SetProperty(ref _combatVoSettingsName, value);
		}
	}
}
