using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorComponent : gameScriptableComponent
	{
		private TweakDBID _vendorTweakID;
		private CArray<JunkItemRecord> _junkItemArray;
		private CName _brandProcessingSFX;
		private CName _itemFallSFX;

		[Ordinal(5)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetProperty(ref _vendorTweakID);
			set => SetProperty(ref _vendorTweakID, value);
		}

		[Ordinal(6)] 
		[RED("junkItemArray")] 
		public CArray<JunkItemRecord> JunkItemArray
		{
			get => GetProperty(ref _junkItemArray);
			set => SetProperty(ref _junkItemArray, value);
		}

		[Ordinal(7)] 
		[RED("brandProcessingSFX")] 
		public CName BrandProcessingSFX
		{
			get => GetProperty(ref _brandProcessingSFX);
			set => SetProperty(ref _brandProcessingSFX, value);
		}

		[Ordinal(8)] 
		[RED("itemFallSFX")] 
		public CName ItemFallSFX
		{
			get => GetProperty(ref _itemFallSFX);
			set => SetProperty(ref _itemFallSFX, value);
		}

		public VendorComponent()
		{
			_brandProcessingSFX = "dev_vending_machine_processing";
			_itemFallSFX = "dev_vending_machine_can_falls";
		}
	}
}
