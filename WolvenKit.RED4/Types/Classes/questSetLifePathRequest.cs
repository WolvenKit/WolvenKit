using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetLifePathRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("lifePathID")] 
		public TweakDBID LifePathID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questSetLifePathRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
