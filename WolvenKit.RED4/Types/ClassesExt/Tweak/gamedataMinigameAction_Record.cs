
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMinigameAction_Record
	{
		[RED("category")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Category
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("complexity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Complexity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
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
		
		[RED("memoryCost")]
		[REDProperty(IsIgnored = true)]
		public CFloat MemoryCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("reward")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Reward
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("showPopup")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowPopup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
