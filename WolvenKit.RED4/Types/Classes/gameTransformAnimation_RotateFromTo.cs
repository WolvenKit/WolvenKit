using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_RotateFromTo : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)] 
		[RED("startRotationEvaluator")] 
		public CHandle<gameTransformAnimation_Rotation> StartRotationEvaluator
		{
			get => GetPropertyValue<CHandle<gameTransformAnimation_Rotation>>();
			set => SetPropertyValue<CHandle<gameTransformAnimation_Rotation>>(value);
		}

		[Ordinal(1)] 
		[RED("targetRotationEvaluator")] 
		public CHandle<gameTransformAnimation_Rotation> TargetRotationEvaluator
		{
			get => GetPropertyValue<CHandle<gameTransformAnimation_Rotation>>();
			set => SetPropertyValue<CHandle<gameTransformAnimation_Rotation>>(value);
		}

		[Ordinal(2)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get => GetPropertyValue<CHandle<gameTransformAnimation_Movement>>();
			set => SetPropertyValue<CHandle<gameTransformAnimation_Movement>>(value);
		}

		public gameTransformAnimation_RotateFromTo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
