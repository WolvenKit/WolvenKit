using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloorIkBase : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("requiredAnimEvent")] 
		public CName RequiredAnimEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("blockAnimEvent")] 
		public CName BlockAnimEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("canBeDisabledDueToFrameRate")] 
		public CBool CanBeDisabledDueToFrameRate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("useFixedVersion")] 
		public CBool UseFixedVersion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("slopeAngleDamp")] 
		public CFloat SlopeAngleDamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("common")] 
		public animSBehaviorConstraintNodeFloorIKCommonData Common
		{
			get => GetPropertyValue<animSBehaviorConstraintNodeFloorIKCommonData>();
			set => SetPropertyValue<animSBehaviorConstraintNodeFloorIKCommonData>(value);
		}

		public animAnimNode_FloorIkBase()
		{
			Id = 4294967295;
			InputLink = new();
			BlockAnimEvent = "AlignToGround";
			UseFixedVersion = true;
			SlopeAngleDamp = 0.200000F;
			Common = new() { GravityCentreBone = new(), RootRotationBlendTime = 0.200000F, VerticalVelocityOffsetUpBlendTime = 0.080000F, VerticalVelocityOffsetDownBlendTime = 0.030000F, SlidingOnSlopeBlendTime = 0.200000F };
		}
	}
}
