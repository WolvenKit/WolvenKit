using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEntityTemplateToAppearancesAndColorVariantsMap : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<gameEntityToAppearancesAndColorVariantsMapEntry> Entries
		{
			get => GetPropertyValue<CArray<gameEntityToAppearancesAndColorVariantsMapEntry>>();
			set => SetPropertyValue<CArray<gameEntityToAppearancesAndColorVariantsMapEntry>>(value);
		}

		public gameEntityTemplateToAppearancesAndColorVariantsMap()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
