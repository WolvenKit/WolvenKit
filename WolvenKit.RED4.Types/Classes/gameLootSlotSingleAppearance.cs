using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootSlotSingleAppearance : gameLootSlotSingleItem
	{
		[Ordinal(49)] 
		[RED("lootAppearance")] 
		public CName LootAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
