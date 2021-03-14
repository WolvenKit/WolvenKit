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
			get
			{
				if (_rows == null)
				{
					_rows = (CArray<animActionAnimDatabase_DatabaseRow>) CR2WTypeManager.Create("array:animActionAnimDatabase_DatabaseRow", "rows", cr2w, this);
				}
				return _rows;
			}
			set
			{
				if (_rows == value)
				{
					return;
				}
				_rows = value;
				PropertySet(this);
			}
		}

		public animActionAnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
