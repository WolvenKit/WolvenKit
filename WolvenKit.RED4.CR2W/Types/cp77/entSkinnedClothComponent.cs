using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSkinnedClothComponent : entISkinTargetComponent
	{
		private raRef<CMesh> _graphicsMesh;
		private raRef<CMesh> _physicalMesh;
		private CBool _isEnabled;
		private CEnum<entMeshComponentLODMode> _lODMode;
		private CName _meshAppearance;
		private CUInt64 _chunkMask;
		private meshCookedClothMeshTopologyData _compiledTopologyData;

		[Ordinal(10)] 
		[RED("graphicsMesh")] 
		public raRef<CMesh> GraphicsMesh
		{
			get => GetProperty(ref _graphicsMesh);
			set => SetProperty(ref _graphicsMesh, value);
		}

		[Ordinal(11)] 
		[RED("physicalMesh")] 
		public raRef<CMesh> PhysicalMesh
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

		public entSkinnedClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
