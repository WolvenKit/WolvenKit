using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerRotationRate3D : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorVector> RotationRate
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		public CParticleInitializerRotationRate3D()
		{
			EditorName = "Inital rotation rate 3D";
			EditorGroup = "Rotation";
			IsEnabled = true;
			RotationRate = new CEvaluatorVectorConst();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
