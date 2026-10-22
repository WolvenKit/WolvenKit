
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldCookedPrefabProxyMeshNode : worldCookedMeshNode
	{
		public worldCookedPrefabProxyMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
