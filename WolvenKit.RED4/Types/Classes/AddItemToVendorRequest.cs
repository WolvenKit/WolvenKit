using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddItemToVendorRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("itemToAddID")] 
		public TweakDBID ItemToAddID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AddItemToVendorRequest()
		{
			Quantity = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
