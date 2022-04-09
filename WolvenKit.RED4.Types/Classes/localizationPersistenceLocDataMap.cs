using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class localizationPersistenceLocDataMap : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<localizationPersistenceLocDataMapEntry> Entries
		{
			get => GetPropertyValue<CArray<localizationPersistenceLocDataMapEntry>>();
			set => SetPropertyValue<CArray<localizationPersistenceLocDataMapEntry>>(value);
		}

		public localizationPersistenceLocDataMap()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
