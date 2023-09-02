using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsPhaseVariant : gamemappinsIPointOfInterestVariant
	{
		[Ordinal(0)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CEnum<gamedataMappinPhase> Phase
		{
			get => GetPropertyValue<CEnum<gamedataMappinPhase>>();
			set => SetPropertyValue<CEnum<gamedataMappinPhase>>(value);
		}

		[Ordinal(2)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get => GetPropertyValue<CEnum<gamedataMappinVariant>>();
			set => SetPropertyValue<CEnum<gamedataMappinVariant>>(value);
		}

		public gamemappinsPhaseVariant()
		{
			MappinType = "Mappins.PointOfInterestMappinDefinition";
			Phase = Enums.gamedataMappinPhase.DefaultPhase;
			Variant = Enums.gamedataMappinVariant.DefaultVariant;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
