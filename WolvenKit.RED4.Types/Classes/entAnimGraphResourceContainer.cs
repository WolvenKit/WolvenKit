using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimGraphResourceContainer : entIComponent
	{
		private CArray<entAnimGraphResourceContainerEntry> _animGraphLookupTable;

		[Ordinal(3)] 
		[RED("animGraphLookupTable")] 
		public CArray<entAnimGraphResourceContainerEntry> AnimGraphLookupTable
		{
			get => GetProperty(ref _animGraphLookupTable);
			set => SetProperty(ref _animGraphLookupTable, value);
		}
	}
}
