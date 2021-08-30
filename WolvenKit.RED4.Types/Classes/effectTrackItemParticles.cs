using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemParticles : effectTrackItem
	{
		private CResourceReference<CParticleSystem> _particleSystem;
		private effectEffectParameterEvaluatorFloat _emissionScale;
		private effectEffectParameterEvaluatorFloat _alpha;
		private effectEffectParameterEvaluatorFloat _size;
		private effectEffectParameterEvaluatorFloat _velocity;
		private CName _soundPositionName;
		private Vector3 _soundPositionOffset;
		private CEnum<RenderSceneLayerMask> _renderLayerMask;

		[Ordinal(3)] 
		[RED("particleSystem")] 
		public CResourceReference<CParticleSystem> ParticleSystem
		{
			get => GetProperty(ref _particleSystem);
			set => SetProperty(ref _particleSystem, value);
		}

		[Ordinal(4)] 
		[RED("emissionScale")] 
		public effectEffectParameterEvaluatorFloat EmissionScale
		{
			get => GetProperty(ref _emissionScale);
			set => SetProperty(ref _emissionScale, value);
		}

		[Ordinal(5)] 
		[RED("alpha")] 
		public effectEffectParameterEvaluatorFloat Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		[Ordinal(6)] 
		[RED("size")] 
		public effectEffectParameterEvaluatorFloat Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(7)] 
		[RED("velocity")] 
		public effectEffectParameterEvaluatorFloat Velocity
		{
			get => GetProperty(ref _velocity);
			set => SetProperty(ref _velocity, value);
		}

		[Ordinal(8)] 
		[RED("soundPositionName")] 
		public CName SoundPositionName
		{
			get => GetProperty(ref _soundPositionName);
			set => SetProperty(ref _soundPositionName, value);
		}

		[Ordinal(9)] 
		[RED("soundPositionOffset")] 
		public Vector3 SoundPositionOffset
		{
			get => GetProperty(ref _soundPositionOffset);
			set => SetProperty(ref _soundPositionOffset, value);
		}

		[Ordinal(10)] 
		[RED("renderLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderLayerMask
		{
			get => GetProperty(ref _renderLayerMask);
			set => SetProperty(ref _renderLayerMask, value);
		}

		public effectTrackItemParticles()
		{
			_renderLayerMask = new() { Value = Enums.RenderSceneLayerMask.Default };
		}
	}
}
