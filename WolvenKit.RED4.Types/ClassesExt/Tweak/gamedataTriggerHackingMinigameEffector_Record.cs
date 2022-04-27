
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTriggerHackingMinigameEffector_Record
	{
		[RED("factName")]
		[REDProperty(IsIgnored = true)]
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("factValue")]
		[REDProperty(IsIgnored = true)]
		public CInt32 FactValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("journalEntry")]
		[REDProperty(IsIgnored = true)]
		public CString JournalEntry
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("showPopup")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowPopup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
