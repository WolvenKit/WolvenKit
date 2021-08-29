using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMenuLayerDefinition : inkLayerDefinition
	{
		private CResourceReference<inkMenuResource> _menuResource;
		private CResourceReference<inkWidgetLibraryResource> _cursorResource;

		[Ordinal(8)] 
		[RED("menuResource")] 
		public CResourceReference<inkMenuResource> MenuResource
		{
			get => GetProperty(ref _menuResource);
			set => SetProperty(ref _menuResource, value);
		}

		[Ordinal(9)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}
	}
}
