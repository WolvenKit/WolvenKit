using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalRequestContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stateFilter")] 
		public gameJournalRequestStateFilter StateFilter
		{
			get => GetPropertyValue<gameJournalRequestStateFilter>();
			set => SetPropertyValue<gameJournalRequestStateFilter>(value);
		}

		[Ordinal(1)] 
		[RED("classFilter")] 
		public gameJournalRequestClassFilter ClassFilter
		{
			get => GetPropertyValue<gameJournalRequestClassFilter>();
			set => SetPropertyValue<gameJournalRequestClassFilter>(value);
		}

		public gameJournalRequestContext()
		{
			StateFilter = new();
			ClassFilter = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
