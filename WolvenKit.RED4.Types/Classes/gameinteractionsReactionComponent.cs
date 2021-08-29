using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsReactionComponent : entIComponent
	{
		private CArray<gameinteractionsReactionData> _reactions;
		private CBool _triggerAutomatically;

		[Ordinal(3)] 
		[RED("reactions")] 
		public CArray<gameinteractionsReactionData> Reactions
		{
			get => GetProperty(ref _reactions);
			set => SetProperty(ref _reactions, value);
		}

		[Ordinal(4)] 
		[RED("triggerAutomatically")] 
		public CBool TriggerAutomatically
		{
			get => GetProperty(ref _triggerAutomatically);
			set => SetProperty(ref _triggerAutomatically, value);
		}
	}
}
