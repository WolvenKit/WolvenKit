using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorTimeoutNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _time;

		[Ordinal(1)] 
		[RED("time")] 
		public CHandle<AIArgumentMapping> Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}
	}
}
