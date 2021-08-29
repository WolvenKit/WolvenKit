using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animGenericAnimDatabase : CResource
	{
		private CArray<animGenericAnimDatabase_DatabaseRow> _rows;

		[Ordinal(1)] 
		[RED("rows")] 
		public CArray<animGenericAnimDatabase_DatabaseRow> Rows
		{
			get => GetProperty(ref _rows);
			set => SetProperty(ref _rows, value);
		}
	}
}
