using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiOnMiniGameStateUpdateEventAdvanced : redEvent
	{
		private CHandle<gameuiSideScrollerMiniGameStateAdvanced> _gameState;
		private CArray<CName> _propertyNames;

		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState
		{
			get => GetProperty(ref _gameState);
			set => SetProperty(ref _gameState, value);
		}

		[Ordinal(1)] 
		[RED("propertyNames")] 
		public CArray<CName> PropertyNames
		{
			get => GetProperty(ref _propertyNames);
			set => SetProperty(ref _propertyNames, value);
		}
	}
}
