using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase : CResource
	{
		private CArray<animGenericAnimDatabase_DatabaseRow> _rows;

		[Ordinal(1)] 
		[RED("rows")] 
		public CArray<animGenericAnimDatabase_DatabaseRow> Rows
		{
			get => GetProperty(ref _rows);
			set => SetProperty(ref _rows, value);
		}

		public animGenericAnimDatabase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
