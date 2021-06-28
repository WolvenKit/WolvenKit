using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDebugLayerEntry : CVariable
	{
		private raRef<inkWidgetLibraryResource> _widgetResource;
		private CEnum<inkEAnchor> _anchorPlace;
		private Vector2 _anchorPoint;

		[Ordinal(0)] 
		[RED("widgetResource")] 
		public raRef<inkWidgetLibraryResource> WidgetResource
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

		public inkDebugLayerEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
