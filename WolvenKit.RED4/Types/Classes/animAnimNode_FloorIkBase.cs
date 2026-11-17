using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloorIkBase : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("requiredAnimEvent")] 
		public CName RequiredAnimEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("blockAnimEvent")] 
		public CName BlockAnimEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("canBeDisabledDueToFrameRate")] 
		public CBool CanBeDisabledDueToFrameRate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("useFixedVersion")] 
		public CBool UseFixedVersion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("slopeAngleDamp")] 
		public CFloat SlopeAngleDamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("common")] 
		public animSBehaviorConstraintNodeFloorIKCommonData Common
		{
			get => GetPropertyValue<animSBehaviorConstraintNodeFloorIKCommonData>();
			set => SetPropertyValue<animSBehaviorConstraintNodeFloorIKCommonData>(value);
		}

		public animAnimNode_FloorIkBase()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			BlockAnimEvent = "AlignToGround";
			UseFixedVersion = true;
			SlopeAngleDamp = 0.200000F;
			Common = new animSBehaviorConstraintNodeFloorIKCommonData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
