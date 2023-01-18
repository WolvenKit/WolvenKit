using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiOnMiniGameStateUpdateEventAdvanced : redEvent
	{
		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState
		{
			get => GetPropertyValue<CHandle<gameuiSideScrollerMiniGameStateAdvanced>>();
			set => SetPropertyValue<CHandle<gameuiSideScrollerMiniGameStateAdvanced>>(value);
		}

		[Ordinal(1)] 
		[RED("propertyNames")] 
		public CArray<CName> PropertyNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameuiOnMiniGameStateUpdateEventAdvanced()
		{
			PropertyNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
