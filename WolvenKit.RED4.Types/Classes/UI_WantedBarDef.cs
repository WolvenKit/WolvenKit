using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_WantedBarDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _currentBounty;
		private gamebbScriptID_Int32 _currentWantedLevel;

		[Ordinal(0)] 
		[RED("CurrentBounty")] 
		public gamebbScriptID_Int32 CurrentBounty
		{
			get => GetProperty(ref _currentBounty);
			set => SetProperty(ref _currentBounty, value);
		}

		[Ordinal(1)] 
		[RED("CurrentWantedLevel")] 
		public gamebbScriptID_Int32 CurrentWantedLevel
		{
			get => GetProperty(ref _currentWantedLevel);
			set => SetProperty(ref _currentWantedLevel, value);
		}
	}
}
