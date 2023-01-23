using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsPointOfInterestMappinData : gamemappinsIMappinData
	{
		[Ordinal(0)] 
		[RED("typedVariant")] 
		public CHandle<gamemappinsIPointOfInterestVariant> TypedVariant
		{
			get => GetPropertyValue<CHandle<gamemappinsIPointOfInterestVariant>>();
			set => SetPropertyValue<CHandle<gamemappinsIPointOfInterestVariant>>(value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamemappinsPointOfInterestMappinData()
		{
			Active = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
