using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoiceoverLengthMap : ISerializable
	{
		private CArray<locVoLengthEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<locVoLengthEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
