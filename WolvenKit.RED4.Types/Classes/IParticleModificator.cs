
namespace WolvenKit.RED4.Types
{
	public partial class IParticleModificator : IParticleInitializer
	{
		public IParticleModificator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
