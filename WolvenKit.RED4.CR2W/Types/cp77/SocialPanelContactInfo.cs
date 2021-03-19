using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactInfo : CVariable
	{
		private CInt32 _hash;
		private wCHandle<gameJournalContact> _contact;

		[Ordinal(0)] 
		[RED("Hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(1)] 
		[RED("Contact")] 
		public wCHandle<gameJournalContact> Contact
		{
			get => GetProperty(ref _contact);
			set => SetProperty(ref _contact, value);
		}

		public SocialPanelContactInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
