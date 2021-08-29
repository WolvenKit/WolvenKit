using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReactionManagerTask : AIbehaviortaskScript
	{
		private CHandle<AIReactionData> _reactionData;

		[Ordinal(0)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetProperty(ref _reactionData);
			set => SetProperty(ref _reactionData, value);
		}
	}
}
