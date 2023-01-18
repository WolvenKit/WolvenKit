using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class attrIcon : attrAttribute
	{
		[Ordinal(0)] 
		[RED("onName")] 
		public CString OnName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public attrIcon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
