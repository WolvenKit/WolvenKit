using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatsManager : IScriptable
	{
		private CHandle<gameStatModifierData_Deprecated> _playerGodModeModifierData;

		[Ordinal(0)] 
		[RED("playerGodModeModifierData")] 
		public CHandle<gameStatModifierData_Deprecated> PlayerGodModeModifierData
		{
			get => GetProperty(ref _playerGodModeModifierData);
			set => SetProperty(ref _playerGodModeModifierData, value);
		}
	}
}
