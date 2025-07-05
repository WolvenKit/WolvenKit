
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameObjectSpawnParameter : ISerializable
	{
		public gameObjectSpawnParameter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
