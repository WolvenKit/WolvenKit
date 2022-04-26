using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtAdvancedEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetPropertyValue<scnAnimTargetBasicData>();
			set => SetPropertyValue<scnAnimTargetBasicData>(value);
		}

		[Ordinal(1)] 
		[RED("requests")] 
		public CArray<animLookAtRequestForPart> Requests
		{
			get => GetPropertyValue<CArray<animLookAtRequestForPart>>();
			set => SetPropertyValue<CArray<animLookAtRequestForPart>>(value);
		}

		public scnLookAtAdvancedEventData()
		{
			Basic = new() { PerformerId = new() { Id = 4294967040 }, IsStart = true, TargetPerformerId = new() { Id = 4294967040 }, TargetSlot = "pla_default_tgt", TargetOffsetEntitySpace = new(), StaticTarget = new() { W = 1.000000F }, TargetActorId = new() { Id = 4294967295 }, TargetPropId = new() { Id = 4294967295 } };
			Requests = new() { new() { BodyPart = "RightHand", Request = new() { TransitionSpeed = 60.000000F, OutTransitionSpeed = 60.000000F, FollowingSpeedFactorOverride = -1.000000F, Limits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F }, Suppress = 1.000000F, Mode = 1, Priority = -1, AdditionalParts = new(0) } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
