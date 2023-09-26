using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipAttachmentEntryData : IScriptable
	{
		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("colorState")] 
		public CName ColorState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("dataPackage")] 
		public CHandle<gameUILocalizationDataPackage> DataPackage
		{
			get => GetPropertyValue<CHandle<gameUILocalizationDataPackage>>();
			set => SetPropertyValue<CHandle<gameUILocalizationDataPackage>>(value);
		}

		[Ordinal(3)] 
		[RED("attunementData")] 
		public CHandle<UIInventoryItemModAttunementData> AttunementData
		{
			get => GetPropertyValue<CHandle<UIInventoryItemModAttunementData>>();
			set => SetPropertyValue<CHandle<UIInventoryItemModAttunementData>>(value);
		}

		public NewItemTooltipAttachmentEntryData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
