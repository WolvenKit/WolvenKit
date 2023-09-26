using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AOEArea : InteractiveMasterDevice
	{
		[Ordinal(98)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(100)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(101)] 
		[RED("visionBlockerComponent")] 
		public CHandle<entIComponent> VisionBlockerComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(102)] 
		[RED("obstacleComponent")] 
		public CHandle<gameinfluenceObstacleComponent> ObstacleComponent
		{
			get => GetPropertyValue<CHandle<gameinfluenceObstacleComponent>>();
			set => SetPropertyValue<CHandle<gameinfluenceObstacleComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("activeStatusEffects")] 
		public CArray<CWeakHandle<gamedataStatusEffect_Record>> ActiveStatusEffects
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatusEffect_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatusEffect_Record>>>(value);
		}

		[Ordinal(104)] 
		[RED("extendPercentAABB")] 
		public CFloat ExtendPercentAABB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(105)] 
		[RED("isAABBExtended")] 
		public CBool IsAABBExtended
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AOEArea()
		{
			ControllerTypeName = "AOEAreaController";
			ActiveStatusEffects = new();
			ExtendPercentAABB = 1.300000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
