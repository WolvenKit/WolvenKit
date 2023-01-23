
namespace WolvenKit.RED4.Types
{
	public partial class PhysicsParticleInitializer : ISerializable
	{
		public PhysicsParticleInitializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
