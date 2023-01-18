using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionUnequipItemState : gameActionReplicatedState
	{
		[Ordinal(5)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("animFeatureNameRight")] 
		public CName AnimFeatureNameRight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("animFeatureNameLeft")] 
		public CName AnimFeatureNameLeft
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameActionUnequipItemState()
		{
			Duration = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
