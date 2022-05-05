using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerRotation3D : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorVector> Rotation
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		public CParticleInitializerRotation3D()
		{
			EditorName = "Inital rotation 3D";
			EditorGroup = "Rotation";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
