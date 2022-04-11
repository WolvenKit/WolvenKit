using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterNetworkLinkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("linksData")] 
		public CArray<SNetworkLinkData> LinksData
		{
			get => GetPropertyValue<CArray<SNetworkLinkData>>();
			set => SetPropertyValue<CArray<SNetworkLinkData>>(value);
		}

		public RegisterNetworkLinkRequest()
		{
			LinksData = new();
		}
	}
}
