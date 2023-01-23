using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scannerQuestEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("categoryName")] 
		public CName CategoryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public scannerQuestEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
