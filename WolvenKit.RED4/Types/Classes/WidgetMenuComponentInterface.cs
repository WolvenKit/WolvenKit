using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WidgetMenuComponentInterface : WidgetBaseComponent
	{
		[Ordinal(5)] 
		[RED("widgetResource")] 
		public CResourceReference<inkWidgetLibraryResource> WidgetResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(6)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(7)] 
		[RED("externalMaterial")] 
		public CResourceReference<CMaterialTemplate> ExternalMaterial
		{
			get => GetPropertyValue<CResourceReference<CMaterialTemplate>>();
			set => SetPropertyValue<CResourceReference<CMaterialTemplate>>(value);
		}

		[Ordinal(8)] 
		[RED("meshTargetBinding")] 
		public CHandle<worlduiMeshTargetBinding> MeshTargetBinding
		{
			get => GetPropertyValue<CHandle<worlduiMeshTargetBinding>>();
			set => SetPropertyValue<CHandle<worlduiMeshTargetBinding>>(value);
		}

		public WidgetMenuComponentInterface()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
