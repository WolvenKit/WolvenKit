using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SBreadcrumbElementData : RedBaseClass
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

		public SBreadcrumbElementData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
