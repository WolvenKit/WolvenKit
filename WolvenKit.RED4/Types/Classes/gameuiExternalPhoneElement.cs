using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiExternalPhoneElement : gameuiLocalPhoneElement
	{
		[Ordinal(6)] 
		[RED("libraryResource")] 
		public CResourceReference<inkWidgetLibraryResource> LibraryResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		public gameuiExternalPhoneElement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
