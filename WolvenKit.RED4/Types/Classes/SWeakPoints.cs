using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SWeakPoints : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("weakPointName")] 
		public CName WeakPointName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("loc_name_key")] 
		public CString Loc_name_key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("loc_desc_key")] 
		public CString Loc_desc_key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SWeakPoints()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
