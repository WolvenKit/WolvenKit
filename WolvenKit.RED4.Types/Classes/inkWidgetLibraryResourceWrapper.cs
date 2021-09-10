using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryResourceWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("library")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> Library
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}
	}
}
