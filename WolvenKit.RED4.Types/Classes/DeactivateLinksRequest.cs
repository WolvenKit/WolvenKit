using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeactivateLinksRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("linksIDs")] 
		public CArray<CInt32> LinksIDs
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeactivateLinksRequest()
		{
			LinksIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
