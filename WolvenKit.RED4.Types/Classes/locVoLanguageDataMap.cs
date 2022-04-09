using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class locVoLanguageDataMap : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<locVoLanguageDataEntry> Entries
		{
			get => GetPropertyValue<CArray<locVoLanguageDataEntry>>();
			set => SetPropertyValue<CArray<locVoLanguageDataEntry>>(value);
		}

		public locVoLanguageDataMap()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
