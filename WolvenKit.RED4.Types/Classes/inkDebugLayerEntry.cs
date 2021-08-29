using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkDebugLayerEntry : RedBaseClass
	{
		private CResourceAsyncReference<inkWidgetLibraryResource> _widgetResource;
		private CEnum<inkEAnchor> _anchorPlace;
		private Vector2 _anchorPoint;

		[Ordinal(0)] 
		[RED("widgetResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> WidgetResource
		{
			get => GetProperty(ref _widgetResource);
			set => SetProperty(ref _widgetResource, value);
		}

		[Ordinal(1)] 
		[RED("anchorPlace")] 
		public CEnum<inkEAnchor> AnchorPlace
		{
			get => GetProperty(ref _anchorPlace);
			set => SetProperty(ref _anchorPlace, value);
		}

		[Ordinal(2)] 
		[RED("anchorPoint")] 
		public Vector2 AnchorPoint
		{
			get => GetProperty(ref _anchorPoint);
			set => SetProperty(ref _anchorPoint, value);
		}
	}
}
