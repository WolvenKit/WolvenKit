using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_SetLifePath : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("lifePathID")] 
		public TweakDBID LifePathID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questCharacterManagerParameters_SetLifePath()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
