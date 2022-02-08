using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReactionManagerTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetPropertyValue<CHandle<AIReactionData>>();
			set => SetPropertyValue<CHandle<AIReactionData>>(value);
		}
	}
}
