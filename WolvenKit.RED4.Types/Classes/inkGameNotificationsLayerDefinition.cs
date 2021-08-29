using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGameNotificationsLayerDefinition : inkLayerDefinition
	{
		private CResourceReference<inkWidgetLibraryResource> _cursorResource;

		[Ordinal(8)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}
	}
}
