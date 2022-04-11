using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnLookAtEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("basicData")] 
		public scnLookAtBasicEventData BasicData
		{
			get => GetPropertyValue<scnLookAtBasicEventData>();
			set => SetPropertyValue<scnLookAtBasicEventData>(value);
		}

		public scnLookAtEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			Duration = 1000;
			BasicData = new() { Basic = new() { PerformerId = new() { Id = 4294967040 }, IsStart = true, TargetPerformerId = new() { Id = 4294967040 }, TargetSlot = "pla_default_tgt", TargetOffsetEntitySpace = new(), StaticTarget = new() { W = 1.000000F }, TargetActorId = new() { Id = 4294967295 }, TargetPropId = new() { Id = 4294967295 } }, RemovePreviousAdvancedLookAts = true, Requests = new() { new() { BodyPart = "Eyes", Request = new() { TransitionSpeed = 60.000000F, OutTransitionSpeed = 60.000000F, FollowingSpeedFactorOverride = -1.000000F, Limits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 270.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 210.000000F }, Priority = -1, AdditionalParts = new(2) }, AttachLeftHandToRightHand = -1, AttachRightHandToLeftHand = -1 } } };
		}
	}
}
