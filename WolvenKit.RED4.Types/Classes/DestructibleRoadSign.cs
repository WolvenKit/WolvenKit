using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DestructibleRoadSign : BaseDestructibleDevice
	{
		[Ordinal(87)] 
		[RED("frameMesh")] 
		public CHandle<entMeshComponent> FrameMesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(88)] 
		[RED("uiMesh")] 
		public CHandle<entMeshComponent> UiMesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(89)] 
		[RED("uiMesh_2")] 
		public CHandle<entMeshComponent> UiMesh_2
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		public DestructibleRoadSign()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
