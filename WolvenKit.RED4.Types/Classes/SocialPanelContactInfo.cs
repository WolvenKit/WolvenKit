using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SocialPanelContactInfo : RedBaseClass
	{
		private CInt32 _hash;
		private CWeakHandle<gameJournalContact> _contact;

		[Ordinal(0)] 
		[RED("Hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(1)] 
		[RED("Contact")] 
		public CWeakHandle<gameJournalContact> Contact
		{
			get => GetProperty(ref _contact);
			set => SetProperty(ref _contact, value);
		}
	}
}
