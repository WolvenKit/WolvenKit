using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ConditionalSegmentBegin : animAnimNode_OnePoseInput
	{
		[Ordinal(13)] 
		[RED("condition")] 
		public animConditionalSegmentCondition Condition
		{
			get => GetPropertyValue<animConditionalSegmentCondition>();
			set => SetPropertyValue<animConditionalSegmentCondition>(value);
		}

		public animAnimNode_ConditionalSegmentBegin()
		{
			Id = 4294967295;
			InputLink = new();
			Condition = new() { Lod = -1 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
