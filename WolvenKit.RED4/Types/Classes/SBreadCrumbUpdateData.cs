using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SBreadCrumbUpdateData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("elementName")] 
		public CString ElementName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("elementID")] 
		public CInt32 ElementID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("context")] 
		public CName Context
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SBreadCrumbUpdateData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
