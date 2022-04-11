using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCommunityEntryInitialState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("initialPhaseName")] 
		public CName InitialPhaseName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("entryActiveOnStart")] 
		public CBool EntryActiveOnStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldCommunityEntryInitialState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
