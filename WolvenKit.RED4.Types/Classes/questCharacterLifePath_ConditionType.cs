using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterLifePath_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("lifePathID")] 
		public TweakDBID LifePathID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questCharacterLifePath_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
