
namespace WolvenKit.RED4.Types
{
	public abstract partial class communitySpawnInitializer : ISerializable
	{
		public communitySpawnInitializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
