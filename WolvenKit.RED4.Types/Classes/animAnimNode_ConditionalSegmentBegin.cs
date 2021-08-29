using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_ConditionalSegmentBegin : animAnimNode_OnePoseInput
	{
		private animConditionalSegmentCondition _condition;

		[Ordinal(13)] 
		[RED("condition")] 
		public animConditionalSegmentCondition Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}
	}
}
