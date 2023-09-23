using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLootSlotSingleAppearance : gameLootSlotSingleItem
	{
		[Ordinal(51)] 
		[RED("lootAppearance")] 
		public CName LootAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameLootSlotSingleAppearance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
