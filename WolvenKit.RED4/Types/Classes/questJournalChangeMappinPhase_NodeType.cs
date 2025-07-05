using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalChangeMappinPhase_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CEnum<gamedataMappinPhase> Phase
		{
			get => GetPropertyValue<CEnum<gamedataMappinPhase>>();
			set => SetPropertyValue<CEnum<gamedataMappinPhase>>(value);
		}

		[Ordinal(2)] 
		[RED("notifyUI")] 
		public CBool NotifyUI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questJournalChangeMappinPhase_NodeType()
		{
			Phase = Enums.gamedataMappinPhase.DefaultPhase;
			NotifyUI = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
