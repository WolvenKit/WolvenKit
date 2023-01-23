using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorRotationRateOverLife : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorFloat> RotationRate
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorRotationRateOverLife()
		{
			EditorName = "Rotation rate over life";
			EditorGroup = "Rotation";
			IsEnabled = true;
			Modulate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
