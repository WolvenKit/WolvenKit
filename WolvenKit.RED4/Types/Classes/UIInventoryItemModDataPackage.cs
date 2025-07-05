using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemModDataPackage : UIInventoryItemMod
	{
		[Ordinal(0)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("DataPackage")] 
		public CHandle<gameUILocalizationDataPackage> DataPackage
		{
			get => GetPropertyValue<CHandle<gameUILocalizationDataPackage>>();
			set => SetPropertyValue<CHandle<gameUILocalizationDataPackage>>(value);
		}

		[Ordinal(2)] 
		[RED("AttunementData")] 
		public CHandle<UIInventoryItemModAttunementData> AttunementData
		{
			get => GetPropertyValue<CHandle<UIInventoryItemModAttunementData>>();
			set => SetPropertyValue<CHandle<UIInventoryItemModAttunementData>>(value);
		}

		public UIInventoryItemModDataPackage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
