using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVendorPanelData : IScriptable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public gameVendorData Data
		{
			get => GetPropertyValue<gameVendorData>();
			set => SetPropertyValue<gameVendorData>(value);
		}

		[Ordinal(1)] 
		[RED("assetsLibrary")] 
		public CString AssetsLibrary
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("rootItemName")] 
		public CName RootItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questVendorPanelData()
		{
			Data = new gameVendorData { EntityID = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
