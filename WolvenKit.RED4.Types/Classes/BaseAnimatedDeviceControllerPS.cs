using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseAnimatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("randomizeAnimationTime")] 
		public CBool RandomizeAnimationTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(107)] 
		[RED("nameForActivation")] 
		public TweakDBID NameForActivation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(108)] 
		[RED("nameForDeactivation")] 
		public TweakDBID NameForDeactivation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public BaseAnimatedDeviceControllerPS()
		{
			DeviceName = "Gameplay-Devices-DisplayNames-RoadBlock";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
