using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerRotationRate : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorFloat> RotationRate
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public CParticleInitializerRotationRate()
		{
			EditorName = "Inital rotation rate";
			EditorGroup = "Rotation";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
