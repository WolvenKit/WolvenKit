using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionEquipItemState : gameActionReplicatedState
	{
		[Ordinal(5)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(7)] 
		[RED("animFeatureNameRight")] 
		public CName AnimFeatureNameRight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("animFeatureNameLeft")] 
		public CName AnimFeatureNameLeft
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("spawnDelay")] 
		public CFloat SpawnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameActionEquipItemState()
		{
			ItemId = new();
			Duration = -1.000000F;
			SpawnDelay = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
