using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkDebugLayerDefinition : inkLayerDefinition
	{
		private CArray<inkDebugLayerEntry> _entries;

		[Ordinal(8)] 
		[RED("entries")] 
		public CArray<inkDebugLayerEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
