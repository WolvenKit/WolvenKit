using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorRotationRate3DOverLife : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorVector> RotationRate
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		public CParticleModificatorRotationRate3DOverLife()
		{
			EditorName = "3D rotation rate over life";
			EditorGroup = "Rotation";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
