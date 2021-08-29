using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAcousticDataResource : resStreamedResource
	{
		private CArray<worldAcousticDataCell> _cells;

		[Ordinal(1)] 
		[RED("cells")] 
		public CArray<worldAcousticDataCell> Cells
		{
			get => GetProperty(ref _cells);
			set => SetProperty(ref _cells, value);
		}
	}
}
