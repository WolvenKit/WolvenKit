
namespace WolvenKit.RED4.Types
{
	public abstract partial class IParticleModificator : IParticleInitializer
	{
		public IParticleModificator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
