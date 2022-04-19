using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_Move : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)] 
		[RED("startPositionEvaluator")] 
		public CHandle<gameTransformAnimation_Position> StartPositionEvaluator
		{
			get => GetPropertyValue<CHandle<gameTransformAnimation_Position>>();
			set => SetPropertyValue<CHandle<gameTransformAnimation_Position>>(value);
		}

		[Ordinal(1)] 
		[RED("targetPositionEvaluator")] 
		public CHandle<gameTransformAnimation_Position> TargetPositionEvaluator
		{
			get => GetPropertyValue<CHandle<gameTransformAnimation_Position>>();
			set => SetPropertyValue<CHandle<gameTransformAnimation_Position>>(value);
		}

		[Ordinal(2)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get => GetPropertyValue<CHandle<gameTransformAnimation_Movement>>();
			set => SetPropertyValue<CHandle<gameTransformAnimation_Movement>>(value);
		}

		public gameTransformAnimation_Move()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
