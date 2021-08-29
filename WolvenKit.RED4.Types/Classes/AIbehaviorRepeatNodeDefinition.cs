using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorRepeatNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _limit;
		private CBool _repeatChildOnFailure;

		[Ordinal(1)] 
		[RED("limit")] 
		public CHandle<AIArgumentMapping> Limit
		{
			get => GetProperty(ref _limit);
			set => SetProperty(ref _limit, value);
		}

		[Ordinal(2)] 
		[RED("repeatChildOnFailure")] 
		public CBool RepeatChildOnFailure
		{
			get => GetProperty(ref _repeatChildOnFailure);
			set => SetProperty(ref _repeatChildOnFailure, value);
		}
	}
}
