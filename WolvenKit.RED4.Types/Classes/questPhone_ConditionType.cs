using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPhone_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("caller")] 
		public CHandle<gameJournalPath> Caller
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CHandle<gameJournalPath> Addressee
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(2)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetPropertyValue<CEnum<questPhoneCallPhase>>();
			set => SetPropertyValue<CEnum<questPhoneCallPhase>>(value);
		}

		public questPhone_ConditionType()
		{
			CallPhase = Enums.questPhoneCallPhase.IncomingCall;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
