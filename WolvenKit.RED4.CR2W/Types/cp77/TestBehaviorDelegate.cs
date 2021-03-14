using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestBehaviorDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CInt32 _integer;
		private CFloat _floatValue;
		private CArray<CName> _names;
		private CHandle<AICommand> _command;
		private CBool _newProperty2;
		private CBool _newProperty;
		private CBool _newProperty3;
		private CBool _newProperty4;
		private NodeRef _nodeRef;

		[Ordinal(0)] 
		[RED("integer")] 
		public CInt32 Integer
		{
			get
			{
				if (_integer == null)
				{
					_integer = (CInt32) CR2WTypeManager.Create("Int32", "integer", cr2w, this);
				}
				return _integer;
			}
			set
			{
				if (_integer == value)
				{
					return;
				}
				_integer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("floatValue")] 
		public CFloat FloatValue
		{
			get
			{
				if (_floatValue == null)
				{
					_floatValue = (CFloat) CR2WTypeManager.Create("Float", "floatValue", cr2w, this);
				}
				return _floatValue;
			}
			set
			{
				if (_floatValue == value)
				{
					return;
				}
				_floatValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get
			{
				if (_names == null)
				{
					_names = (CArray<CName>) CR2WTypeManager.Create("array:CName", "names", cr2w, this);
				}
				return _names;
			}
			set
			{
				if (_names == value)
				{
					return;
				}
				_names = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("command")] 
		public CHandle<AICommand> Command
		{
			get
			{
				if (_command == null)
				{
					_command = (CHandle<AICommand>) CR2WTypeManager.Create("handle:AICommand", "command", cr2w, this);
				}
				return _command;
			}
			set
			{
				if (_command == value)
				{
					return;
				}
				_command = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("newProperty2")] 
		public CBool NewProperty2
		{
			get
			{
				if (_newProperty2 == null)
				{
					_newProperty2 = (CBool) CR2WTypeManager.Create("Bool", "newProperty2", cr2w, this);
				}
				return _newProperty2;
			}
			set
			{
				if (_newProperty2 == value)
				{
					return;
				}
				_newProperty2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("newProperty")] 
		public CBool NewProperty
		{
			get
			{
				if (_newProperty == null)
				{
					_newProperty = (CBool) CR2WTypeManager.Create("Bool", "newProperty", cr2w, this);
				}
				return _newProperty;
			}
			set
			{
				if (_newProperty == value)
				{
					return;
				}
				_newProperty = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("newProperty3")] 
		public CBool NewProperty3
		{
			get
			{
				if (_newProperty3 == null)
				{
					_newProperty3 = (CBool) CR2WTypeManager.Create("Bool", "newProperty3", cr2w, this);
				}
				return _newProperty3;
			}
			set
			{
				if (_newProperty3 == value)
				{
					return;
				}
				_newProperty3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("newProperty4")] 
		public CBool NewProperty4
		{
			get
			{
				if (_newProperty4 == null)
				{
					_newProperty4 = (CBool) CR2WTypeManager.Create("Bool", "newProperty4", cr2w, this);
				}
				return _newProperty4;
			}
			set
			{
				if (_newProperty4 == value)
				{
					return;
				}
				_newProperty4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		public TestBehaviorDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
