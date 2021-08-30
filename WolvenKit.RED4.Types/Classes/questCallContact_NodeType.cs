using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCallContact_NodeType : questIPhoneManagerNodeType
	{
		private CHandle<gameJournalPath> _caller;
		private CHandle<gameJournalPath> _addressee;
		private CEnum<questPhoneCallPhase> _phase;
		private CEnum<questPhoneCallMode> _mode;
		private NodeRef _prefabNodeRef;
		private CBool _applyPhoneRestriction;
		private CBool _isRejectable;

		[Ordinal(0)] 
		[RED("caller")] 
		public CHandle<gameJournalPath> Caller
		{
			get => GetProperty(ref _caller);
			set => SetProperty(ref _caller, value);
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CHandle<gameJournalPath> Addressee
		{
			get => GetProperty(ref _addressee);
			set => SetProperty(ref _addressee, value);
		}

		[Ordinal(2)] 
		[RED("phase")] 
		public CEnum<questPhoneCallPhase> Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}

		[Ordinal(3)] 
		[RED("mode")] 
		public CEnum<questPhoneCallMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(4)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetProperty(ref _prefabNodeRef);
			set => SetProperty(ref _prefabNodeRef, value);
		}

		[Ordinal(5)] 
		[RED("applyPhoneRestriction")] 
		public CBool ApplyPhoneRestriction
		{
			get => GetProperty(ref _applyPhoneRestriction);
			set => SetProperty(ref _applyPhoneRestriction, value);
		}

		[Ordinal(6)] 
		[RED("isRejectable")] 
		public CBool IsRejectable
		{
			get => GetProperty(ref _isRejectable);
			set => SetProperty(ref _isRejectable, value);
		}

		public questCallContact_NodeType()
		{
			_phase = new() { Value = Enums.questPhoneCallPhase.IncomingCall };
			_mode = new() { Value = Enums.questPhoneCallMode.Audio };
			_applyPhoneRestriction = true;
		}
	}
}
