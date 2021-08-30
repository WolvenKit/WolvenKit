using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSkinnedClothComponent : entISkinTargetComponent
	{
		private CResourceAsyncReference<CMesh> _graphicsMesh;
		private CResourceAsyncReference<CMesh> _physicalMesh;
		private CBool _isEnabled;
		private CEnum<entMeshComponentLODMode> _lODMode;
		private CName _meshAppearance;
		private CUInt64 _chunkMask;
		private meshCookedClothMeshTopologyData _compiledTopologyData;

		[Ordinal(10)] 
		[RED("graphicsMesh")] 
		public CResourceAsyncReference<CMesh> GraphicsMesh
		{
			get => GetProperty(ref _graphicsMesh);
			set => SetProperty(ref _graphicsMesh, value);
		}

		[Ordinal(11)] 
		[RED("physicalMesh")] 
		public CResourceAsyncReference<CMesh> PhysicalMesh
		{
			get => GetProperty(ref _physicalMesh);
			set => SetProperty(ref _physicalMesh, value);
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(13)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get => GetProperty(ref _lODMode);
			set => SetProperty(ref _lODMode, value);
		}

		[Ordinal(14)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(15)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetProperty(ref _chunkMask);
			set => SetProperty(ref _chunkMask, value);
		}

		[Ordinal(16)] 
		[RED("compiledTopologyData")] 
		public meshCookedClothMeshTopologyData CompiledTopologyData
		{
			get => GetProperty(ref _compiledTopologyData);
			set => SetProperty(ref _compiledTopologyData, value);
		}

		public entSkinnedClothComponent()
		{
			_isEnabled = true;
			_meshAppearance = "default";
			_chunkMask = 18446744073709551615;
		}
	}
}
