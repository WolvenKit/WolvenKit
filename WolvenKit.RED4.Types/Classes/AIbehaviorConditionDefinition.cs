using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorConditionDefinition : AIbehaviorBehaviorComponentDefinition
	{
		private CBool _isInverted;

		[Ordinal(0)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get => GetProperty(ref _isInverted);
			set => SetProperty(ref _isInverted, value);
		}
	}
}
