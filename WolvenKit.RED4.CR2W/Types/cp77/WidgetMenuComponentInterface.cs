using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WidgetMenuComponentInterface : WidgetBaseComponent
	{
		private rRef<inkWidgetLibraryResource> _widgetResource;
		private rRef<inkWidgetLibraryResource> _cursorResource;
		private rRef<CMaterialTemplate> _externalMaterial;
		private CHandle<worlduiMeshTargetBinding> _meshTargetBinding;

		[Ordinal(5)] 
		[RED("widgetResource")] 
		public rRef<inkWidgetLibraryResource> WidgetResource
		{
			get => GetProperty(ref _widgetResource);
			set => SetProperty(ref _widgetResource, value);
		}

		[Ordinal(6)] 
		[RED("cursorResource")] 
		public rRef<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}

		[Ordinal(7)] 
		[RED("externalMaterial")] 
		public rRef<CMaterialTemplate> ExternalMaterial
		{
			get => GetProperty(ref _externalMaterial);
			set => SetProperty(ref _externalMaterial, value);
		}

		[Ordinal(8)] 
		[RED("meshTargetBinding")] 
		public CHandle<worlduiMeshTargetBinding> MeshTargetBinding
		{
			get => GetProperty(ref _meshTargetBinding);
			set => SetProperty(ref _meshTargetBinding, value);
		}

		public WidgetMenuComponentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
