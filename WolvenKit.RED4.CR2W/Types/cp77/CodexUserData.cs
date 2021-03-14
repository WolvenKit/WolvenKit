using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexUserData : IScriptable
	{
		private CEnum<CodexDataSource> _dataSource;

		[Ordinal(0)] 
		[RED("DataSource")] 
		public CEnum<CodexDataSource> DataSource
		{
			get
			{
				if (_dataSource == null)
				{
					_dataSource = (CEnum<CodexDataSource>) CR2WTypeManager.Create("CodexDataSource", "DataSource", cr2w, this);
				}
				return _dataSource;
			}
			set
			{
				if (_dataSource == value)
				{
					return;
				}
				_dataSource = value;
				PropertySet(this);
			}
		}

		public CodexUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
