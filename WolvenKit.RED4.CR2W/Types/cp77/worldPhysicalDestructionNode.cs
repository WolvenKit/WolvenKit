using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalDestructionNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CInt32 _forceLODLevel;
		private CFloat _forceAutoHideDistance;
		private physicsDestructionParams _destructionParams;
		private CArray<physicsDestructionLevelData> _destructionLevelData;
		private CName _audioMetadata;
		private NavGenNavigationSetting _navigationSetting;
		private CBool _useMeshNavmeshSettings;

		[Ordinal(4)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(5)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(6)] 
		[RED("forceLODLevel")] 
		public CInt32 ForceLODLevel
		{
			get => GetProperty(ref _forceLODLevel);
			set => SetProperty(ref _forceLODLevel, value);
		}

		[Ordinal(7)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get => GetProperty(ref _forceAutoHideDistance);
			set => SetProperty(ref _forceAutoHideDistance, value);
		}

		[Ordinal(8)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get => GetProperty(ref _destructionParams);
			set => SetProperty(ref _destructionParams, value);
		}

		[Ordinal(9)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get => GetProperty(ref _destructionLevelData);
			set => SetProperty(ref _destructionLevelData, value);
		}

		[Ordinal(10)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetProperty(ref _audioMetadata);
			set => SetProperty(ref _audioMetadata, value);
		}

		[Ordinal(11)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetProperty(ref _navigationSetting);
			set => SetProperty(ref _navigationSetting, value);
		}

		[Ordinal(12)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetProperty(ref _useMeshNavmeshSettings);
			set => SetProperty(ref _useMeshNavmeshSettings, value);
		}

		public worldPhysicalDestructionNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
