
namespace WolvenKit.RED4.Types
{
	public abstract partial class PhysicsParticleInitializer : ISerializable
	{
		public PhysicsParticleInitializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
