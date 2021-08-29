using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterReactionAction : AIbehaviortaskScript
	{
		private CName _reactionName;
		private CBool _onDeactivation;

		[Ordinal(0)] 
		[RED("reactionName")] 
		public CName ReactionName
		{
			get => GetProperty(ref _reactionName);
			set => SetProperty(ref _reactionName, value);
		}

		[Ordinal(1)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get => GetProperty(ref _onDeactivation);
			set => SetProperty(ref _onDeactivation, value);
		}
	}
}
