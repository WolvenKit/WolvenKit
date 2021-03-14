using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataPackageNode : ISerializable
	{
		private CString _name;
		private CArray<CHandle<gamedataVariableNode>> _serializedVariables;
		private CArray<CHandle<gamedataGroupNode>> _serializedGroups;
		private CArray<CHandle<gamedataFileNode>> _files;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("serializedVariables")] 
		public CArray<CHandle<gamedataVariableNode>> SerializedVariables
		{
			get
			{
				if (_serializedVariables == null)
				{
					_serializedVariables = (CArray<CHandle<gamedataVariableNode>>) CR2WTypeManager.Create("array:handle:gamedataVariableNode", "serializedVariables", cr2w, this);
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

		[Ordinal(2)] 
		[RED("serializedGroups")] 
		public CArray<CHandle<gamedataGroupNode>> SerializedGroups
		{
			get
			{
				if (_serializedGroups == null)
				{
					_serializedGroups = (CArray<CHandle<gamedataGroupNode>>) CR2WTypeManager.Create("array:handle:gamedataGroupNode", "serializedGroups", cr2w, this);
				}
				return _serializedGroups;
			}
			set
			{
				if (_serializedGroups == value)
				{
					return;
				}
				_serializedGroups = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("files")] 
		public CArray<CHandle<gamedataFileNode>> Files
		{
			get
			{
				if (_files == null)
				{
					_files = (CArray<CHandle<gamedataFileNode>>) CR2WTypeManager.Create("array:handle:gamedataFileNode", "files", cr2w, this);
				}
				return _files;
			}
			set
			{
				if (_files == value)
				{
					return;
				}
				_files = value;
				PropertySet(this);
			}
		}

		public gamedataPackageNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
