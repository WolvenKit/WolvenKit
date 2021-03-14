using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataGroupNode : gamedataDataNode
	{
		private CString _name;
		private CString _base;
		private CString _schema;
		private CBool _isInline;
		private wCHandle<gamedataGroupNode> _baseGroup;
		private wCHandle<gamedataGroupNode> _schemaGroup;
		private wCHandle<gamedataPackageNode> _package;
		private CHandle<gamedataFileNode> _fileNode;
		private CUInt32 _inlineGroupId;
		private CEnum<gamedataGroupNodeInheritanceState> _inheritanceState;
		private CArray<gamedataGroupNodeGroupVariable> _serializedVariables;
		private CArray<CName> _tags;

		[Ordinal(3)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
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

		[Ordinal(4)] 
		[RED("base")] 
		public CString Base
		{
			get
			{
				if (_base == null)
				{
					_base = (CString) CR2WTypeManager.Create("String", "base", cr2w, this);
				}
				return _base;
			}
			set
			{
				if (_base == value)
				{
					return;
				}
				_base = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("schema")] 
		public CString Schema
		{
			get
			{
				if (_schema == null)
				{
					_schema = (CString) CR2WTypeManager.Create("String", "schema", cr2w, this);
				}
				return _schema;
			}
			set
			{
				if (_schema == value)
				{
					return;
				}
				_schema = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isInline")] 
		public CBool IsInline
		{
			get
			{
				if (_isInline == null)
				{
					_isInline = (CBool) CR2WTypeManager.Create("Bool", "isInline", cr2w, this);
				}
				return _isInline;
			}
			set
			{
				if (_isInline == value)
				{
					return;
				}
				_isInline = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("baseGroup")] 
		public wCHandle<gamedataGroupNode> BaseGroup
		{
			get
			{
				if (_baseGroup == null)
				{
					_baseGroup = (wCHandle<gamedataGroupNode>) CR2WTypeManager.Create("whandle:gamedataGroupNode", "baseGroup", cr2w, this);
				}
				return _baseGroup;
			}
			set
			{
				if (_baseGroup == value)
				{
					return;
				}
				_baseGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("schemaGroup")] 
		public wCHandle<gamedataGroupNode> SchemaGroup
		{
			get
			{
				if (_schemaGroup == null)
				{
					_schemaGroup = (wCHandle<gamedataGroupNode>) CR2WTypeManager.Create("whandle:gamedataGroupNode", "schemaGroup", cr2w, this);
				}
				return _schemaGroup;
			}
			set
			{
				if (_schemaGroup == value)
				{
					return;
				}
				_schemaGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("package")] 
		public wCHandle<gamedataPackageNode> Package
		{
			get
			{
				if (_package == null)
				{
					_package = (wCHandle<gamedataPackageNode>) CR2WTypeManager.Create("whandle:gamedataPackageNode", "package", cr2w, this);
				}
				return _package;
			}
			set
			{
				if (_package == value)
				{
					return;
				}
				_package = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("fileNode")] 
		public CHandle<gamedataFileNode> FileNode
		{
			get
			{
				if (_fileNode == null)
				{
					_fileNode = (CHandle<gamedataFileNode>) CR2WTypeManager.Create("handle:gamedataFileNode", "fileNode", cr2w, this);
				}
				return _fileNode;
			}
			set
			{
				if (_fileNode == value)
				{
					return;
				}
				_fileNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inlineGroupId")] 
		public CUInt32 InlineGroupId
		{
			get
			{
				if (_inlineGroupId == null)
				{
					_inlineGroupId = (CUInt32) CR2WTypeManager.Create("Uint32", "inlineGroupId", cr2w, this);
				}
				return _inlineGroupId;
			}
			set
			{
				if (_inlineGroupId == value)
				{
					return;
				}
				_inlineGroupId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inheritanceState")] 
		public CEnum<gamedataGroupNodeInheritanceState> InheritanceState
		{
			get
			{
				if (_inheritanceState == null)
				{
					_inheritanceState = (CEnum<gamedataGroupNodeInheritanceState>) CR2WTypeManager.Create("gamedataGroupNodeInheritanceState", "inheritanceState", cr2w, this);
				}
				return _inheritanceState;
			}
			set
			{
				if (_inheritanceState == value)
				{
					return;
				}
				_inheritanceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("serializedVariables")] 
		public CArray<gamedataGroupNodeGroupVariable> SerializedVariables
		{
			get
			{
				if (_serializedVariables == null)
				{
					_serializedVariables = (CArray<gamedataGroupNodeGroupVariable>) CR2WTypeManager.Create("array:gamedataGroupNodeGroupVariable", "serializedVariables", cr2w, this);
				}
				return _serializedVariables;
			}
			set
			{
				if (_serializedVariables == value)
				{
					return;
				}
				_serializedVariables = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		public gamedataGroupNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
