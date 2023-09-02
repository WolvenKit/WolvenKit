using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsCommonVariant : gamemappinsIPointOfInterestVariant
	{
		[Ordinal(0)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get => GetPropertyValue<CEnum<gamedataMappinVariant>>();
			set => SetPropertyValue<CEnum<gamedataMappinVariant>>(value);
		}

		public gamemappinsCommonVariant()
		{
			MappinType = "Mappins.PointOfInterestMappinDefinition";
			Variant = Enums.gamedataMappinVariant.DefaultVariant;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
