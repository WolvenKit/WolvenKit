using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsStaticCollisionShapeDebugInfo : RedBaseClass
	{
		private CUInt64 _sourceMeshPathHash;
		private CUInt64 _prefabPathHash;
		private CUInt64 _nodeNameHash;

		[Ordinal(0)] 
		[RED("sourceMeshPathHash")] 
		public CUInt64 SourceMeshPathHash
		{
			get => GetProperty(ref _sourceMeshPathHash);
			set => SetProperty(ref _sourceMeshPathHash, value);
		}

		[Ordinal(1)] 
		[RED("prefabPathHash")] 
		public CUInt64 PrefabPathHash
		{
			get => GetProperty(ref _prefabPathHash);
			set => SetProperty(ref _prefabPathHash, value);
		}

		[Ordinal(2)] 
		[RED("nodeNameHash")] 
		public CUInt64 NodeNameHash
		{
			get => GetProperty(ref _nodeNameHash);
			set => SetProperty(ref _nodeNameHash, value);
		}
	}
}
