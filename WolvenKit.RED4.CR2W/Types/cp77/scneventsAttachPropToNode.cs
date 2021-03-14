using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToNode : scnSceneEvent
	{
		private scnPropId _propId;
		private NodeRef _nodeRef;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;

		[Ordinal(6)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get
			{
				if (_propId == null)
				{
					_propId = (scnPropId) CR2WTypeManager.Create("scnPropId", "propId", cr2w, this);
				}
				return _propId;
			}
			set
			{
				if (_propId == value)
				{
					return;
				}
				_propId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get
			{
				if (_customOffsetPos == null)
				{
					_customOffsetPos = (Vector3) CR2WTypeManager.Create("Vector3", "customOffsetPos", cr2w, this);
				}
				return _customOffsetPos;
			}
			set
			{
				if (_customOffsetPos == value)
				{
					return;
				}
				_customOffsetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get
			{
				if (_customOffsetRot == null)
				{
					_customOffsetRot = (Quaternion) CR2WTypeManager.Create("Quaternion", "customOffsetRot", cr2w, this);
				}
				return _customOffsetRot;
			}
			set
			{
				if (_customOffsetRot == value)
				{
					return;
				}
				_customOffsetRot = value;
				PropertySet(this);
			}
		}

		public scneventsAttachPropToNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
