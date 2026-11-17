using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorTextureAnimation : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("initialFrame")] 
		public CHandle<IEvaluatorFloat> InitialFrame
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("animationSpeed")] 
		public CHandle<IEvaluatorFloat> AnimationSpeed
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("animationMode")] 
		public CEnum<ETextureAnimationMode> AnimationMode
		{
			get => GetPropertyValue<CEnum<ETextureAnimationMode>>();
			set => SetPropertyValue<CEnum<ETextureAnimationMode>>(value);
		}

		public CParticleModificatorTextureAnimation()
		{
			EditorName = "Texture animation";
			EditorGroup = "Material";
			IsEnabled = true;
			InitialFrame = new CEvaluatorFloatConst { Value = 0.000000F };
			AnimationSpeed = new CEvaluatorFloatConst { Value = 30.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
