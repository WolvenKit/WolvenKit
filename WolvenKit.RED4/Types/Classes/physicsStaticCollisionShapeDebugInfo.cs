using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsStaticCollisionShapeDebugInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sourceMeshPathHash")] 
		public CUInt64 SourceMeshPathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("prefabPathHash")] 
		public CUInt64 PrefabPathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("nodeNameHash")] 
		public CUInt64 NodeNameHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public physicsStaticCollisionShapeDebugInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
