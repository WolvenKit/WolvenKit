using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorVelocityTurbulize : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorVector> Scale
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("timelifeLimit")] 
		public CHandle<IEvaluatorFloat> TimelifeLimit
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("noiseInterval")] 
		public CFloat NoiseInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorVelocityTurbulize()
		{
			EditorName = "Velocity turbulize";
			EditorGroup = "Velocity";
			IsEnabled = true;
			NoiseInterval = 1.000000F;
			Duration = 1.000000F;
			WorldSpace = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
