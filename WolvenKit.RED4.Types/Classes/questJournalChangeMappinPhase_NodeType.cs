using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questJournalChangeMappinPhase_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CEnum<gamedataMappinPhase> _phase;
		private CBool _notifyUI;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CEnum<gamedataMappinPhase> Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}

		[Ordinal(2)] 
		[RED("notifyUI")] 
		public CBool NotifyUI
		{
			get => GetProperty(ref _notifyUI);
			set => SetProperty(ref _notifyUI, value);
		}
	}
}
