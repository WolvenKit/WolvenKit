using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WidgetHudComponentInterface : WidgetBaseComponent
	{
		private rRef<inkHudEntriesResource> _hudEntriesResource;
		private rRef<CMaterialTemplate> _externalMaterial;
		private CHandle<worlduiMeshTargetBinding> _meshTargetBinding;

		[Ordinal(5)] 
		[RED("hudEntriesResource")] 
		public rRef<inkHudEntriesResource> HudEntriesResource
		{
			get => GetProperty(ref _hudEntriesResource);
			set => SetProperty(ref _hudEntriesResource, value);
		}

		[Ordinal(6)] 
		[RED("externalMaterial")] 
		public rRef<CMaterialTemplate> ExternalMaterial
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

		public WidgetHudComponentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
