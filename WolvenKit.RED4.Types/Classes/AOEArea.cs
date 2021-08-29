using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AOEArea : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CHandle<gameEffectInstance> _gameEffect;
		private CBool _highLightActive;
		private CHandle<entIComponent> _visionBlockerComponent;
		private CHandle<gameinfluenceObstacleComponent> _obstacleComponent;
		private CArray<CWeakHandle<gamedataStatusEffect_Record>> _activeStatusEffects;
		private CFloat _extendPercentAABB;
		private CBool _isAABBExtended;

		[Ordinal(97)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(98)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetProperty(ref _gameEffect);
			set => SetProperty(ref _gameEffect, value);
		}

		[Ordinal(99)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetProperty(ref _highLightActive);
			set => SetProperty(ref _highLightActive, value);
		}

		[Ordinal(100)] 
		[RED("visionBlockerComponent")] 
		public CHandle<entIComponent> VisionBlockerComponent
		{
			get => GetProperty(ref _visionBlockerComponent);
			set => SetProperty(ref _visionBlockerComponent, value);
		}

		[Ordinal(101)] 
		[RED("obstacleComponent")] 
		public CHandle<gameinfluenceObstacleComponent> ObstacleComponent
		{
			get => GetProperty(ref _obstacleComponent);
			set => SetProperty(ref _obstacleComponent, value);
		}

		[Ordinal(102)] 
		[RED("activeStatusEffects")] 
		public CArray<CWeakHandle<gamedataStatusEffect_Record>> ActiveStatusEffects
		{
			get => GetProperty(ref _activeStatusEffects);
			set => SetProperty(ref _activeStatusEffects, value);
		}

		[Ordinal(103)] 
		[RED("extendPercentAABB")] 
		public CFloat ExtendPercentAABB
		{
			get => GetProperty(ref _extendPercentAABB);
			set => SetProperty(ref _extendPercentAABB, value);
		}

		[Ordinal(104)] 
		[RED("isAABBExtended")] 
		public CBool IsAABBExtended
		{
			get => GetProperty(ref _isAABBExtended);
			set => SetProperty(ref _isAABBExtended, value);
		}
	}
}
