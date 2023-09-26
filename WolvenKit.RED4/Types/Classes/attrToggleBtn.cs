using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class attrToggleBtn : attrAttribute
	{
		[Ordinal(0)] 
		[RED("nLabel")] 
		public CString NLabel
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public attrToggleBtn()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
