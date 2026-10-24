using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ConditionalSegmentBegin : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("condition")] 
		public animConditionalSegmentCondition Condition
		{
			get => GetPropertyValue<animConditionalSegmentCondition>();
			set => SetPropertyValue<animConditionalSegmentCondition>(value);
		}

		public animAnimNode_ConditionalSegmentBegin()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			Condition = new animConditionalSegmentCondition();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
