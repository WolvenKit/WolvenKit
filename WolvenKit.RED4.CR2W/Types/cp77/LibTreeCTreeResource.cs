using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeCTreeResource : CResource
	{
		private LibTreeDefTreeVariablesList _variables;

		[Ordinal(1)] 
		[RED("variables")] 
		public LibTreeDefTreeVariablesList Variables
		{
			get
			{
				if (_variables == null)
				{
					_variables = (LibTreeDefTreeVariablesList) CR2WTypeManager.Create("LibTreeDefTreeVariablesList", "variables", cr2w, this);
				}
				return _variables;
			}
			set
			{
				if (_variables == value)
				{
					return;
				}
				_variables = value;
				PropertySet(this);
			}
		}

		public LibTreeCTreeResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
