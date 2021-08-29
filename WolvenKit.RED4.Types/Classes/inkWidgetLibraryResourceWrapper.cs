using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryResourceWrapper : RedBaseClass
	{
		private CResourceAsyncReference<inkWidgetLibraryResource> _library;

		[Ordinal(0)] 
		[RED("library")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> Library
		{
			get => GetProperty(ref _library);
			set => SetProperty(ref _library, value);
		}
	}
}
