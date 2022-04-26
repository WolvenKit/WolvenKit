using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLootSlot : gameLootContainerBase
	{
		[Ordinal(45)] 
		[RED("immovableAfterDrop")] 
		public CBool ImmovableAfterDrop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("dropChance")] 
		public CFloat DropChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("lootState")] 
		public CBitField<gameLootSlotState> LootState
		{
			get => GetPropertyValue<CBitField<gameLootSlotState>>();
			set => SetPropertyValue<CBitField<gameLootSlotState>>(value);
		}

		public gameLootSlot()
		{
			DropChance = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
