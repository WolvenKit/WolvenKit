using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class localizationPersistenceOnScreenEntries : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<localizationPersistenceOnScreenEntry> Entries
		{
			get => GetPropertyValue<CArray<localizationPersistenceOnScreenEntry>>();
			set => SetPropertyValue<CArray<localizationPersistenceOnScreenEntry>>(value);
		}

		public localizationPersistenceOnScreenEntries()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
