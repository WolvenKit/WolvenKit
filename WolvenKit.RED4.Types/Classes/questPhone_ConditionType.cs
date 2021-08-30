using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhone_ConditionType : questISystemConditionType
	{
		private CHandle<gameJournalPath> _caller;
		private CHandle<gameJournalPath> _addressee;
		private CEnum<questPhoneCallPhase> _callPhase;

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
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetProperty(ref _callPhase);
			set => SetProperty(ref _callPhase, value);
		}

		public questPhone_ConditionType()
		{
			_callPhase = new() { Value = Enums.questPhoneCallPhase.IncomingCall };
		}
	}
}
