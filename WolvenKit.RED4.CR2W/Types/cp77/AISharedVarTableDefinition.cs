using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISharedVarTableDefinition : CVariable
	{
		private CArray<AISharedVarDefinition> _table;

		[Ordinal(0)] 
		[RED("table")] 
		public CArray<AISharedVarDefinition> Table
		{
			get
			{
				if (_table == null)
				{
					_table = (CArray<AISharedVarDefinition>) CR2WTypeManager.Create("array:AISharedVarDefinition", "table", cr2w, this);
				}
				return _table;
			}
			set
			{
				if (_table == value)
				{
					return;
				}
				_table = value;
				PropertySet(this);
			}
		}

		public AISharedVarTableDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
