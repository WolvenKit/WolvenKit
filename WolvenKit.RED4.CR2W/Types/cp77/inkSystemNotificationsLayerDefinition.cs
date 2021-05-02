using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSystemNotificationsLayerDefinition : inkLayerDefinition
	{
		private rRef<inkWidgetLibraryResource> _cursorResource;

		[Ordinal(8)] 
		[RED("cursorResource")] 
		public rRef<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}

		public inkSystemNotificationsLayerDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
