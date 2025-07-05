using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerVelocityInherit : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public CParticleInitializerVelocityInherit()
		{
			EditorName = "Inherit velocity";
			EditorGroup = "Velocity";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
