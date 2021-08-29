using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPhysicalDestructionComponent : entIVisualComponent
	{
		private CResourceAsyncReference<CMesh> _mesh;
		private CName _meshAppearance;
		private CFloat _forceAutoHideDistance;
		private physicsDestructionParams _destructionParams;
		private CArray<physicsDestructionLevelData> _destructionLevelData;
		private CBool _isEnabled;
		private CName _audioMetadata;

		[Ordinal(8)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(9)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(10)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get => GetProperty(ref _forceAutoHideDistance);
			set => SetProperty(ref _forceAutoHideDistance, value);
		}

		[Ordinal(11)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get => GetProperty(ref _destructionParams);
			set => SetProperty(ref _destructionParams, value);
		}

		[Ordinal(12)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get => GetProperty(ref _destructionLevelData);
			set => SetProperty(ref _destructionLevelData, value);
		}

		[Ordinal(13)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(14)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetProperty(ref _audioMetadata);
			set => SetProperty(ref _audioMetadata, value);
		}
	}
}
