using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communitySquadInitializer : communitySpawnInitializer
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<communitySquadInitializerEntry> Entries
		{
			get => GetPropertyValue<CArray<communitySquadInitializerEntry>>();
			set => SetPropertyValue<CArray<communitySquadInitializerEntry>>(value);
		}

		public communitySquadInitializer()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
