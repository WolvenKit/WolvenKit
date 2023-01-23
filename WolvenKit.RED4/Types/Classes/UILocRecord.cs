using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UILocRecord : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public UILocRecord()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
