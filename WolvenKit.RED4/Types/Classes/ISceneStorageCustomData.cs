
namespace WolvenKit.RED4.Types
{
	public abstract partial class ISceneStorageCustomData : RedBaseClass
	{
		public ISceneStorageCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
