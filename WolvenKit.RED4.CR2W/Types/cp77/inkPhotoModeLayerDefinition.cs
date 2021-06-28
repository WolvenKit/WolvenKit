using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPhotoModeLayerDefinition : inkLayerDefinition
	{
		private rRef<inkWidgetLibraryResource> _photoModeResource;
		private rRef<inkWidgetLibraryResource> _stickersResource;
		private rRef<inkWidgetLibraryResource> _cursorResource;

		[Ordinal(8)] 
		[RED("photoModeResource")] 
		public rRef<inkWidgetLibraryResource> PhotoModeResource
		{
			get => GetProperty(ref _photoModeResource);
			set => SetProperty(ref _photoModeResource, value);
		}

		[Ordinal(9)] 
		[RED("stickersResource")] 
		public rRef<inkWidgetLibraryResource> StickersResource
		{
			get => GetProperty(ref _stickersResource);
			set => SetProperty(ref _stickersResource, value);
		}

		[Ordinal(10)] 
		[RED("cursorResource")] 
		public rRef<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}

		public inkPhotoModeLayerDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
