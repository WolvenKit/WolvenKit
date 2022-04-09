using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterNetworkLinksByIDRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public entEntityID ID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public UnregisterNetworkLinksByIDRequest()
		{
			ID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
