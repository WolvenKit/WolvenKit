using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlatformSpecificPatchNote : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("platformName")] 
		public CString PlatformName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("platformNameToSkip")] 
		public CString PlatformNameToSkip
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public PlatformSpecificPatchNote()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
