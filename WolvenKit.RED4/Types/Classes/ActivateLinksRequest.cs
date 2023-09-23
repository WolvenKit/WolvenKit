using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivateLinksRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("linksIDs")] 
		public CArray<CInt32> LinksIDs
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public ActivateLinksRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
