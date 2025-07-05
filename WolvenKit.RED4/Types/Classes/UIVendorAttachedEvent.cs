using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIVendorAttachedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("vendorObject")] 
		public CWeakHandle<gameObject> VendorObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public UIVendorAttachedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
