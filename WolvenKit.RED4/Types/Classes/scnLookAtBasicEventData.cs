using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtBasicEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetPropertyValue<scnAnimTargetBasicData>();
			set => SetPropertyValue<scnAnimTargetBasicData>(value);
		}

		[Ordinal(1)] 
		[RED("removePreviousAdvancedLookAts")] 
		public CBool RemovePreviousAdvancedLookAts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("requests")] 
		public CArray<animLookAtRequestForPart> Requests
		{
			get => GetPropertyValue<CArray<animLookAtRequestForPart>>();
			set => SetPropertyValue<CArray<animLookAtRequestForPart>>(value);
		}

		public scnLookAtBasicEventData()
		{
			Basic = new scnAnimTargetBasicData { PerformerId = new scnPerformerId { Id = 4294967040 }, IsStart = true, TargetPerformerId = new scnPerformerId { Id = 4294967040 }, TargetSlot = "pla_default_tgt", TargetOffsetEntitySpace = new Vector4(), StaticTarget = new Vector4 { W = 1.000000F }, TargetActorId = new scnActorId { Id = uint.MaxValue }, TargetPropId = new scnPropId { Id = uint.MaxValue } };
			RemovePreviousAdvancedLookAts = true;
			Requests = new() { new animLookAtRequestForPart { BodyPart = "Eyes", Request = new animLookAtRequest { TransitionSpeed = 60.000000F, OutTransitionSpeed = 60.000000F, FollowingSpeedFactorOverride = -1.000000F, Limits = new animLookAtLimits { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 270.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 210.000000F }, Priority = -1, AdditionalParts = new(2) }, AttachLeftHandToRightHand = -1, AttachRightHandToLeftHand = -1 } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
