using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDestructibleProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(20)] 
		[RED("ownerHash")] 
		public CUInt64 OwnerHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public worldDestructibleProxyMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
