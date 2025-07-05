using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimDatabaseCollection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animDatabases")] 
		public CArray<animAnimDatabaseCollectionEntry> AnimDatabases
		{
			get => GetPropertyValue<CArray<animAnimDatabaseCollectionEntry>>();
			set => SetPropertyValue<CArray<animAnimDatabaseCollectionEntry>>(value);
		}

		public animAnimDatabaseCollection()
		{
			AnimDatabases = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
