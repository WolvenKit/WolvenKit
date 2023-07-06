using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtAdvancedEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("advancedData")] 
		public scnLookAtAdvancedEventData AdvancedData
		{
			get => GetPropertyValue<scnLookAtAdvancedEventData>();
			set => SetPropertyValue<scnLookAtAdvancedEventData>(value);
		}

		public scnLookAtAdvancedEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Duration = 1000;
			AdvancedData = new scnLookAtAdvancedEventData { Basic = new scnAnimTargetBasicData { PerformerId = new scnPerformerId { Id = 4294967040 }, IsStart = true, TargetPerformerId = new scnPerformerId { Id = 4294967040 }, TargetSlot = "pla_default_tgt", TargetOffsetEntitySpace = new Vector4(), StaticTarget = new Vector4 { W = 1.000000F }, TargetActorId = new scnActorId { Id = uint.MaxValue }, TargetPropId = new scnPropId { Id = uint.MaxValue } }, Requests = new() { new animLookAtRequestForPart { BodyPart = "RightHand", Request = new animLookAtRequest { TransitionSpeed = 60.000000F, OutTransitionSpeed = 60.000000F, FollowingSpeedFactorOverride = -1.000000F, Limits = new animLookAtLimits { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F }, Suppress = 1.000000F, Mode = 1, Priority = -1, AdditionalParts = new(0) } } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
