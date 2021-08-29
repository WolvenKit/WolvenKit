using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAdditionalTransformContainer : RedBaseClass
	{
		private CArray<CHandle<animAdditionalTransformEntry>> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<CHandle<animAdditionalTransformEntry>> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
