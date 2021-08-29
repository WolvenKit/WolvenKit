using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckReactionValueThreshold : AIbehaviorconditionScript
	{
		private CEnum<EReactionValue> _reactionValue;

		[Ordinal(0)] 
		[RED("reactionValue")] 
		public CEnum<EReactionValue> ReactionValue
		{
			get => GetProperty(ref _reactionValue);
			set => SetProperty(ref _reactionValue, value);
		}
	}
}
