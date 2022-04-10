using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerVelocity : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("velocity")] 
		public CHandle<IEvaluatorVector> Velocity
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleInitializerVelocity()
		{
			EditorName = "Initial velocity";
			EditorGroup = "Velocity";
			IsEnabled = true;
			Scale = 1.000000F;
			WorldSpace = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
