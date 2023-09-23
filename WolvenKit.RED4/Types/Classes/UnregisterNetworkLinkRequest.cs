using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterNetworkLinkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("linksData")] 
		public CArray<SNetworkLinkData> LinksData
		{
			get => GetPropertyValue<CArray<SNetworkLinkData>>();
			set => SetPropertyValue<CArray<SNetworkLinkData>>(value);
		}

		public UnregisterNetworkLinkRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
