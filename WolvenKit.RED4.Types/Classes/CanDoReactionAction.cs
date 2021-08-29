using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CanDoReactionAction : AIbehaviorconditionScript
	{
		private CName _reactionName;

		[Ordinal(0)] 
		[RED("reactionName")] 
		public CName ReactionName
		{
			get => GetProperty(ref _reactionName);
			set => SetProperty(ref _reactionName, value);
		}
	}
}
