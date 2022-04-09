using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MarketSystemRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public MarketSystemRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
