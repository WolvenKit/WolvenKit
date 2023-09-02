using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemParticles : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("particleSystem")] 
		public CResourceReference<CParticleSystem> ParticleSystem
		{
			get => GetPropertyValue<CResourceReference<CParticleSystem>>();
			set => SetPropertyValue<CResourceReference<CParticleSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("emissionScale")] 
		public effectEffectParameterEvaluatorFloat EmissionScale
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("alpha")] 
		public effectEffectParameterEvaluatorFloat Alpha
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(6)] 
		[RED("size")] 
		public effectEffectParameterEvaluatorFloat Size
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(7)] 
		[RED("velocity")] 
		public effectEffectParameterEvaluatorFloat Velocity
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(8)] 
		[RED("soundPositionName")] 
		public CName SoundPositionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("soundPositionOffset")] 
		public Vector3 SoundPositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(10)] 
		[RED("renderLayerMask")] 
		public CBitField<RenderSceneLayerMask> RenderLayerMask
		{
			get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
			set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
		}

		public effectTrackItemParticles()
		{
			TimeDuration = 1.000000F;
			EmissionScale = new effectEffectParameterEvaluatorFloat();
			Alpha = new effectEffectParameterEvaluatorFloat();
			Size = new effectEffectParameterEvaluatorFloat();
			Velocity = new effectEffectParameterEvaluatorFloat();
			SoundPositionOffset = new Vector3();
			RenderLayerMask = Enums.RenderSceneLayerMask.Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
