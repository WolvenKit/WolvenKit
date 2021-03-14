using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeCTreeReference : ISerializable
	{
		private rRef<LibTreeCTreeResource> _treeDefinition;
		private LibTreeParameterList _parameters;

		[Ordinal(0)] 
		[RED("TreeDefinition")] 
		public rRef<LibTreeCTreeResource> TreeDefinition
		{
			get
			{
				if (_treeDefinition == null)
				{
					_treeDefinition = (rRef<LibTreeCTreeResource>) CR2WTypeManager.Create("rRef:LibTreeCTreeResource", "TreeDefinition", cr2w, this);
				}
				return _treeDefinition;
			}
			set
			{
				if (_treeDefinition == value)
				{
					return;
				}
				_treeDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parameters")] 
		public LibTreeParameterList Parameters
		{
			get
			{
				if (_parameters == null)
				{
					_parameters = (LibTreeParameterList) CR2WTypeManager.Create("LibTreeParameterList", "parameters", cr2w, this);
				}
				return _parameters;
			}
			set
			{
				if (_parameters == value)
				{
					return;
				}
				_parameters = value;
				PropertySet(this);
			}
		}

		public LibTreeCTreeReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
