using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPhonePickUp_ConditionType : questISystemConditionType
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
		[RED("releaseOnRejection")] 
		public CBool ReleaseOnRejection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPhonePickUp_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
