using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class localizationPersistenceSubtitleEntries : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<localizationPersistenceSubtitleEntry> Entries
		{
			get => GetPropertyValue<CArray<localizationPersistenceSubtitleEntry>>();
			set => SetPropertyValue<CArray<localizationPersistenceSubtitleEntry>>(value);
		}

		public localizationPersistenceSubtitleEntries()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
