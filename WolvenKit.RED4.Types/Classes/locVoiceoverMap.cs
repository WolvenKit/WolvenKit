using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoiceoverMap : ISerializable
	{
		private CArray<locVoLineEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<locVoLineEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
