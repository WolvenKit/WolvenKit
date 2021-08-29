using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntityTemplateToAppearancesAndColorVariantsMap : ISerializable
	{
		private CArray<gameEntityToAppearancesAndColorVariantsMapEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<gameEntityToAppearancesAndColorVariantsMapEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
