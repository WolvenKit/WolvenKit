using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entSkinnedClothComponent : entISkinTargetComponent
	{
		[Ordinal(11)] 
		[RED("graphicsMesh")] 
		public CResourceAsyncReference<CMesh> GraphicsMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(12)] 
		[RED("physicalMesh")] 
		public CResourceAsyncReference<CMesh> PhysicalMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(13)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get => GetPropertyValue<CEnum<entMeshComponentLODMode>>();
			set => SetPropertyValue<CEnum<entMeshComponentLODMode>>(value);
		}

		[Ordinal(15)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(17)] 
		[RED("compiledTopologyData")] 
		public meshCookedClothMeshTopologyData CompiledTopologyData
		{
			get => GetPropertyValue<meshCookedClothMeshTopologyData>();
			set => SetPropertyValue<meshCookedClothMeshTopologyData>(value);
		}

		public entSkinnedClothComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			BoundingBoxLocalBoundsOverride = -1.000000F;
			IsEnabled = true;
			MeshAppearance = "default";
			ChunkMask = ulong.MaxValue;
			CompiledTopologyData = new meshCookedClothMeshTopologyData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
