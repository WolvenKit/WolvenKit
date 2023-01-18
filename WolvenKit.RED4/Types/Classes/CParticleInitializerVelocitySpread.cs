using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerVelocitySpread : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("conserveMomentum")] 
		public CBool ConserveMomentum
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleInitializerVelocitySpread()
		{
			EditorName = "Spread velocity";
			EditorGroup = "Velocity";
			IsEnabled = true;
			ConserveMomentum = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
