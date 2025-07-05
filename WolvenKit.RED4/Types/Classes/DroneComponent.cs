using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DroneComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("senseComponent")] 
		public CHandle<senseComponent> SenseComponent
		{
			get => GetPropertyValue<CHandle<senseComponent>>();
			set => SetPropertyValue<CHandle<senseComponent>>(value);
		}

		[Ordinal(6)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(7)] 
		[RED("playerOnlyCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> PlayerOnlyCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(8)] 
		[RED("highLevelCb")] 
		public CUInt32 HighLevelCb
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get => GetPropertyValue<CEnum<MechanicalScanType>>();
			set => SetPropertyValue<CEnum<MechanicalScanType>>(value);
		}

		[Ordinal(10)] 
		[RED("currentScanEffect")] 
		public CHandle<gameEffectInstance> CurrentScanEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(11)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("isDetectionScanning")] 
		public CBool IsDetectionScanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("trackedTarget")] 
		public CWeakHandle<gameObject> TrackedTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(14)] 
		[RED("currentLocomotionWrapper")] 
		public CName CurrentLocomotionWrapper
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DroneComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
