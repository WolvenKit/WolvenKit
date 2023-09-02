using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entSkinnedClothComponent : entISkinTargetComponent
	{
		[Ordinal(10)] 
		[RED("graphicsMesh")] 
		public CResourceAsyncReference<CMesh> GraphicsMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(11)] 
		[RED("physicalMesh")] 
		public CResourceAsyncReference<CMesh> PhysicalMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get => GetPropertyValue<CEnum<entMeshComponentLODMode>>();
			set => SetPropertyValue<CEnum<entMeshComponentLODMode>>(value);
		}

		[Ordinal(14)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(16)] 
		[RED("compiledTopologyData")] 
		public meshCookedClothMeshTopologyData CompiledTopologyData
		{
			get => GetPropertyValue<meshCookedClothMeshTopologyData>();
			set => SetPropertyValue<meshCookedClothMeshTopologyData>(value);
		}

		public entSkinnedClothComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			IsEnabled = true;
			MeshAppearance = "default";
			ChunkMask = long.MaxValue;
			CompiledTopologyData = new meshCookedClothMeshTopologyData { GfxIndexToTriangles = new(), PhxIndexToTriangles = new(), GfxBarycentrics = new(), PhxBarycentrics = new(), PhxLodSwitchData = new(), PhxSimulated = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
