using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterNetworkLinkBetweenTwoEntitiesRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("firstID")] 
		public entEntityID FirstID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("secondID")] 
		public entEntityID SecondID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("onlyRemoveWeakLink")] 
		public CBool OnlyRemoveWeakLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UnregisterNetworkLinkBetweenTwoEntitiesRequest()
		{
			FirstID = new entEntityID();
			SecondID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
