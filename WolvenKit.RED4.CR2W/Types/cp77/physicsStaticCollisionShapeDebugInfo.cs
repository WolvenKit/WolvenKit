using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsStaticCollisionShapeDebugInfo : CVariable
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

		public physicsStaticCollisionShapeDebugInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
