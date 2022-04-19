using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVendorPanel_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("scenarioName")] 
		public CName ScenarioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("openVendorPanel")] 
		public CBool OpenVendorPanel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("vendorId")] 
		public CString VendorId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(4)] 
		[RED("assetsLibrary")] 
		public CString AssetsLibrary
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("rootItemName")] 
		public CName RootItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questVendorPanel_NodeType()
		{
			ScenarioName = "MenuScenario_Vendor";
			OpenVendorPanel = true;
			ObjectRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
