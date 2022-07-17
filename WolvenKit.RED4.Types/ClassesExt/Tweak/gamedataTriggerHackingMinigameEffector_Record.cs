
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTriggerHackingMinigameEffector_Record
	{
		[RED("journalEntry")]
		[REDProperty(IsIgnored = true)]
		public CString JournalEntry
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("reward")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Reward
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
