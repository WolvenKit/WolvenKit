using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animStackTransformsExtender_JsonProperties : ISerializable
	{
		private CArray<animStackTransformsExtender_JsonEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animStackTransformsExtender_JsonEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
