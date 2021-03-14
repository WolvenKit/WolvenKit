using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnWorldMarker : CVariable
	{
		private CEnum<scnWorldMarkerType> _type;
		private CName _tag;
		private NodeRef _nodeRef;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnWorldMarkerType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<scnWorldMarkerType>) CR2WTypeManager.Create("scnWorldMarkerType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public scnWorldMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
