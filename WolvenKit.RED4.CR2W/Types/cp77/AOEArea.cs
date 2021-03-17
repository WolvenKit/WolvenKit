using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AOEArea : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CHandle<gameEffectInstance> _gameEffect;
		private CBool _highLightActive;
		private CHandle<entIComponent> _visionBlockerComponent;
		private CHandle<gameinfluenceObstacleComponent> _obstacleComponent;
		private CArray<wCHandle<gamedataStatusEffect_Record>> _activeStatusEffects;
		private CFloat _extendPercentAABB;
		private CBool _isAABBExtended;

		[Ordinal(93)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(94)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetProperty(ref _gameEffect);
			set => SetProperty(ref _gameEffect, value);
		}

		[Ordinal(95)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetProperty(ref _highLightActive);
			set => SetProperty(ref _highLightActive, value);
		}

		[Ordinal(96)] 
		[RED("visionBlockerComponent")] 
		public CHandle<entIComponent> VisionBlockerComponent
		{
			get => GetProperty(ref _visionBlockerComponent);
			set => SetProperty(ref _visionBlockerComponent, value);
		}

		[Ordinal(97)] 
		[RED("obstacleComponent")] 
		public CHandle<gameinfluenceObstacleComponent> ObstacleComponent
		{
			get => GetProperty(ref _obstacleComponent);
			set => SetProperty(ref _obstacleComponent, value);
		}

		[Ordinal(98)] 
		[RED("activeStatusEffects")] 
		public CArray<wCHandle<gamedataStatusEffect_Record>> ActiveStatusEffects
		{
			get => GetProperty(ref _activeStatusEffects);
			set => SetProperty(ref _activeStatusEffects, value);
		}

		[Ordinal(99)] 
		[RED("extendPercentAABB")] 
		public CFloat ExtendPercentAABB
		{
			get => GetProperty(ref _extendPercentAABB);
			set => SetProperty(ref _extendPercentAABB, value);
		}

		[Ordinal(100)] 
		[RED("isAABBExtended")] 
		public CBool IsAABBExtended
		{
			get => GetProperty(ref _isAABBExtended);
			set => SetProperty(ref _isAABBExtended, value);
		}

		public AOEArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
