using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLootSlotSingleQuery : gameLootSlot
	{
		[Ordinal(50)] 
		[RED("queryTDBID")] 
		public TweakDBID QueryTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameLootSlotSingleQuery()
		{
			UseAreaLoot = false;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
