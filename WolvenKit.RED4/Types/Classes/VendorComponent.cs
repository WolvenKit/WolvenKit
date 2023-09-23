using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("junkItemArray")] 
		public CArray<JunkItemRecord> JunkItemArray
		{
			get => GetPropertyValue<CArray<JunkItemRecord>>();
			set => SetPropertyValue<CArray<JunkItemRecord>>(value);
		}

		[Ordinal(7)] 
		[RED("brandProcessingSFX")] 
		public CName BrandProcessingSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("itemFallSFX")] 
		public CName ItemFallSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public VendorComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
