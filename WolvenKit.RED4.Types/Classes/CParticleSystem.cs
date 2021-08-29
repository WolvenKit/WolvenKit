using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleSystem : resStreamedResource
	{
		private CBool _visibleThroughWalls;
		private CFloat _prewarmingTime;
		private CArray<CHandle<CParticleEmitter>> _emitters;
		private Box _boundingBox;
		private CFloat _autoHideDistance;
		private CFloat _autoHideRange;
		private CFloat _lastLODFadeoutRange;
		private CEnum<ERenderingPlane> _renderingPlane;
		private CHandle<ParticleDamage> _particleDamage;

		[Ordinal(1)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get => GetProperty(ref _visibleThroughWalls);
			set => SetProperty(ref _visibleThroughWalls, value);
		}

		[Ordinal(2)] 
		[RED("prewarmingTime")] 
		public CFloat PrewarmingTime
		{
			get => GetProperty(ref _prewarmingTime);
			set => SetProperty(ref _prewarmingTime, value);
		}

		[Ordinal(3)] 
		[RED("emitters")] 
		public CArray<CHandle<CParticleEmitter>> Emitters
		{
			get => GetProperty(ref _emitters);
			set => SetProperty(ref _emitters, value);
		}

		[Ordinal(4)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetProperty(ref _boundingBox);
			set => SetProperty(ref _boundingBox, value);
		}

		[Ordinal(5)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetProperty(ref _autoHideDistance);
			set => SetProperty(ref _autoHideDistance, value);
		}

		[Ordinal(6)] 
		[RED("autoHideRange")] 
		public CFloat AutoHideRange
		{
			get => GetProperty(ref _autoHideRange);
			set => SetProperty(ref _autoHideRange, value);
		}

		[Ordinal(7)] 
		[RED("lastLODFadeoutRange")] 
		public CFloat LastLODFadeoutRange
		{
			get => GetProperty(ref _lastLODFadeoutRange);
			set => SetProperty(ref _lastLODFadeoutRange, value);
		}

		[Ordinal(8)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get => GetProperty(ref _renderingPlane);
			set => SetProperty(ref _renderingPlane, value);
		}

		[Ordinal(9)] 
		[RED("particleDamage")] 
		public CHandle<ParticleDamage> ParticleDamage
		{
			get => GetProperty(ref _particleDamage);
			set => SetProperty(ref _particleDamage, value);
		}
	}
}
