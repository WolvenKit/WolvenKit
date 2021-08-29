using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoLanguageDataMap : ISerializable
	{
		private CArray<locVoLanguageDataEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<locVoLanguageDataEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
