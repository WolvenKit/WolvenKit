using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootSlotSingleAppearance : gameLootSlotSingleItem
	{
		private CName _lootAppearance;

		[Ordinal(54)] 
		[RED("lootAppearance")] 
		public CName LootAppearance
		{
			get => GetProperty(ref _lootAppearance);
			set => SetProperty(ref _lootAppearance, value);
		}
	}
}
