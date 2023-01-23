using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class localizationPersistenceSubtitleMap : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<localizationPersistenceSubtitleMapEntry> Entries
		{
			get => GetPropertyValue<CArray<localizationPersistenceSubtitleMapEntry>>();
			set => SetPropertyValue<CArray<localizationPersistenceSubtitleMapEntry>>(value);
		}

		public localizationPersistenceSubtitleMap()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
