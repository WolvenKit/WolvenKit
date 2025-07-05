using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLootSlotSingleItem : gameLootSlot
	{
		[Ordinal(50)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameLootSlotSingleItem()
		{
			UseAreaLoot = false;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
