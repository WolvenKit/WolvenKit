using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedAnimFeaturesState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<entReplicatedAnimFeature> Items
		{
			get => GetPropertyValue<CArray<entReplicatedAnimFeature>>();
			set => SetPropertyValue<CArray<entReplicatedAnimFeature>>(value);
		}

		[Ordinal(1)] 
		[RED("lastAppliedActionsTime")] 
		public netTime LastAppliedActionsTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public entReplicatedAnimFeaturesState()
		{
			Items = new();
			LastAppliedActionsTime = new netTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
