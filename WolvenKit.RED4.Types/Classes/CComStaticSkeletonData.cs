using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CComStaticSkeletonData : RedBaseClass
	{
		private CArray<CComStaticSkeletonDataEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<CComStaticSkeletonDataEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
