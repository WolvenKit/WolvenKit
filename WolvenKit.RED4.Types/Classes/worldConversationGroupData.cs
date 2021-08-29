using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldConversationGroupData : ISerializable
	{
		private CResourceReference<scnInterestingConversationsResource> _conversationGroup;
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;
		private CBool _ignoreLocalLimit;
		private CBool _ignoreGlobalLimit;

		[Ordinal(0)] 
		[RED("conversationGroup")] 
		public CResourceReference<scnInterestingConversationsResource> ConversationGroup
		{
			get => GetProperty(ref _conversationGroup);
			set => SetProperty(ref _conversationGroup, value);
		}

		[Ordinal(1)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetProperty(ref _interruptionOperations);
			set => SetProperty(ref _interruptionOperations, value);
		}

		[Ordinal(2)] 
		[RED("ignoreLocalLimit")] 
		public CBool IgnoreLocalLimit
		{
			get => GetProperty(ref _ignoreLocalLimit);
			set => SetProperty(ref _ignoreLocalLimit, value);
		}

		[Ordinal(3)] 
		[RED("ignoreGlobalLimit")] 
		public CBool IgnoreGlobalLimit
		{
			get => GetProperty(ref _ignoreGlobalLimit);
			set => SetProperty(ref _ignoreGlobalLimit, value);
		}
	}
}
