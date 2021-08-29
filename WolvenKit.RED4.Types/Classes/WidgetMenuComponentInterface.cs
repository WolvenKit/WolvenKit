using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetMenuComponentInterface : WidgetBaseComponent
	{
		private CResourceReference<inkWidgetLibraryResource> _widgetResource;
		private CResourceReference<inkWidgetLibraryResource> _cursorResource;
		private CResourceReference<CMaterialTemplate> _externalMaterial;
		private CHandle<worlduiMeshTargetBinding> _meshTargetBinding;

		[Ordinal(5)] 
		[RED("widgetResource")] 
		public CResourceReference<inkWidgetLibraryResource> WidgetResource
		{
			get => GetProperty(ref _widgetResource);
			set => SetProperty(ref _widgetResource, value);
		}

		[Ordinal(6)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}

		[Ordinal(7)] 
		[RED("externalMaterial")] 
		public CResourceReference<CMaterialTemplate> ExternalMaterial
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
	}
}
