
namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorAlphaOverEffect : IParticleModificator
	{
		public CParticleModificatorAlphaOverEffect()
		{
			EditorName = "Effect alpha";
			EditorGroup = "Material";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
