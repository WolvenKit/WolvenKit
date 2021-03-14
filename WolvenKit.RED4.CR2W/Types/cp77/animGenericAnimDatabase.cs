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
			get
			{
				if (_rows == null)
				{
					_rows = (CArray<animGenericAnimDatabase_DatabaseRow>) CR2WTypeManager.Create("array:animGenericAnimDatabase_DatabaseRow", "rows", cr2w, this);
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

		public animGenericAnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
