using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SocialPanelContactInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Hash")] 
		public CInt32 Hash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("Contact")] 
		public CWeakHandle<gameJournalContact> Contact
		{
			get => GetPropertyValue<CWeakHandle<gameJournalContact>>();
			set => SetPropertyValue<CWeakHandle<gameJournalContact>>(value);
		}

		public SocialPanelContactInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
