using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ExplorationAdjuster : animAnimNode_MotionAdjuster
	{
		[Ordinal(16)] 
		[RED("targetPosition2")] 
		public animVectorLink TargetPosition2
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(17)] 
		[RED("targetDirection2")] 
		public animVectorLink TargetDirection2
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(18)] 
		[RED("totalTimeToAdjust2")] 
		public animFloatLink TotalTimeToAdjust2
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(19)] 
		[RED("targetPosition3")] 
		public animVectorLink TargetPosition3
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(20)] 
		[RED("targetDirection3")] 
		public animVectorLink TargetDirection3
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(21)] 
		[RED("totalTimeToAdjust3")] 
		public animFloatLink TotalTimeToAdjust3
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_ExplorationAdjuster()
		{
			TargetPosition2 = new();
			TargetDirection2 = new();
			TotalTimeToAdjust2 = new();
			TargetPosition3 = new();
			TargetDirection3 = new();
			TotalTimeToAdjust3 = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
