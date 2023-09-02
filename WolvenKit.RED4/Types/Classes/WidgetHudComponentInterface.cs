using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WidgetHudComponentInterface : WidgetBaseComponent
	{
		[Ordinal(5)] 
		[RED("hudEntriesResource")] 
		public CResourceReference<inkHudEntriesResource> HudEntriesResource
		{
			get => GetPropertyValue<CResourceReference<inkHudEntriesResource>>();
			set => SetPropertyValue<CResourceReference<inkHudEntriesResource>>(value);
		}

		[Ordinal(6)] 
		[RED("externalMaterial")] 
		public CResourceReference<CMaterialTemplate> ExternalMaterial
		{
			get => GetPropertyValue<CResourceReference<CMaterialTemplate>>();
			set => SetPropertyValue<CResourceReference<CMaterialTemplate>>(value);
		}

		[Ordinal(7)] 
		[RED("meshTargetBinding")] 
		public CHandle<worlduiMeshTargetBinding> MeshTargetBinding
		{
			get => GetPropertyValue<CHandle<worlduiMeshTargetBinding>>();
			set => SetPropertyValue<CHandle<worlduiMeshTargetBinding>>(value);
		}

		public WidgetHudComponentInterface()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
