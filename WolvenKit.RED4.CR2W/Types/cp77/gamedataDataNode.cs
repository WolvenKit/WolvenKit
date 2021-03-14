using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataDataNode : ISerializable
	{
		private CEnum<gamedataDataNodeType> _nodeType;
		private CString _fileName;
		private wCHandle<gamedataDataNode> _parent;

		[Ordinal(0)] 
		[RED("nodeType")] 
		public CEnum<gamedataDataNodeType> NodeType
		{
			get
			{
				if (_nodeType == null)
				{
					_nodeType = (CEnum<gamedataDataNodeType>) CR2WTypeManager.Create("gamedataDataNodeType", "nodeType", cr2w, this);
				}
				return _nodeType;
			}
			set
			{
				if (_nodeType == value)
				{
					return;
				}
				_nodeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fileName")] 
		public CString FileName
		{
			get
			{
				if (_fileName == null)
				{
					_fileName = (CString) CR2WTypeManager.Create("String", "fileName", cr2w, this);
				}
				return _fileName;
			}
			set
			{
				if (_fileName == value)
				{
					return;
				}
				_fileName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parent")] 
		public wCHandle<gamedataDataNode> Parent
		{
			get
			{
				if (_parent == null)
				{
					_parent = (wCHandle<gamedataDataNode>) CR2WTypeManager.Create("whandle:gamedataDataNode", "parent", cr2w, this);
				}
				return _parent;
			}
			set
			{
				if (_parent == value)
				{
					return;
				}
				_parent = value;
				PropertySet(this);
			}
		}

		public gamedataDataNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
