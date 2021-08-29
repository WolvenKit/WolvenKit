using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetHudComponentInterface : WidgetBaseComponent
	{
		private CResourceReference<inkHudEntriesResource> _hudEntriesResource;
		private CResourceReference<CMaterialTemplate> _externalMaterial;
		private CHandle<worlduiMeshTargetBinding> _meshTargetBinding;

		[Ordinal(5)] 
		[RED("hudEntriesResource")] 
		public CResourceReference<inkHudEntriesResource> HudEntriesResource
		{
			get => GetProperty(ref _hudEntriesResource);
			set => SetProperty(ref _hudEntriesResource, value);
		}

		[Ordinal(6)] 
		[RED("externalMaterial")] 
		public CResourceReference<CMaterialTemplate> ExternalMaterial
		{
			get => GetProperty(ref _externalMaterial);
			set => SetProperty(ref _externalMaterial, value);
		}

		[Ordinal(7)] 
		[RED("meshTargetBinding")] 
		public CHandle<worlduiMeshTargetBinding> MeshTargetBinding
		{
			get => GetProperty(ref _meshTargetBinding);
			set => SetProperty(ref _meshTargetBinding, value);
		}
	}
}
