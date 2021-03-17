using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase : CResource
	{
		private CArray<animActionAnimDatabase_DatabaseRow> _rows;

		[Ordinal(1)] 
		[RED("rows")] 
		public CArray<animActionAnimDatabase_DatabaseRow> Rows
		{
			get => GetProperty(ref _rows);
			set => SetProperty(ref _rows, value);
		}

		public animActionAnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
