using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckReaction : AIbehaviorconditionScript
	{
		private CEnum<gamedataOutput> _reactionToCompare;

		[Ordinal(0)] 
		[RED("reactionToCompare")] 
		public CEnum<gamedataOutput> ReactionToCompare
		{
			get => GetProperty(ref _reactionToCompare);
			set => SetProperty(ref _reactionToCompare, value);
		}
	}
}
