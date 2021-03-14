using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphSocketDefinition : graphIGraphObjectDefinition
	{
		private CName _name;
		private CArray<CHandle<graphGraphConnectionDefinition>> _connections;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("connections")] 
		public CArray<CHandle<graphGraphConnectionDefinition>> Connections
		{
			get
			{
				if (_connections == null)
				{
					_connections = (CArray<CHandle<graphGraphConnectionDefinition>>) CR2WTypeManager.Create("array:handle:graphGraphConnectionDefinition", "connections", cr2w, this);
				}
				return _connections;
			}
			set
			{
				if (_connections == value)
				{
					return;
				}
				_connections = value;
				PropertySet(this);
			}
		}

		public graphGraphSocketDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
