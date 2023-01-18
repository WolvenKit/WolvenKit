using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerAlpha : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("alpha")] 
		public CHandle<IEvaluatorFloat> Alpha
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public CParticleInitializerAlpha()
		{
			EditorName = "Initial alpha";
			EditorGroup = "Material";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
