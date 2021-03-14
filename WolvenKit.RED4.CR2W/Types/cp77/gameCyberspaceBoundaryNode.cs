using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCyberspaceBoundaryNode : worldTriggerAreaNode
	{
		private NodeRef _marker1Ref;
		private NodeRef _marker2Ref;

		[Ordinal(7)] 
		[RED("marker1Ref")] 
		public NodeRef Marker1Ref
		{
			get
			{
				if (_marker1Ref == null)
				{
					_marker1Ref = (NodeRef) CR2WTypeManager.Create("NodeRef", "marker1Ref", cr2w, this);
				}
				return _marker1Ref;
			}
			set
			{
				if (_marker1Ref == value)
				{
					return;
				}
				_marker1Ref = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("marker2Ref")] 
		public NodeRef Marker2Ref
		{
			get
			{
				if (_marker2Ref == null)
				{
					_marker2Ref = (NodeRef) CR2WTypeManager.Create("NodeRef", "marker2Ref", cr2w, this);
				}
				return _marker2Ref;
			}
			set
			{
				if (_marker2Ref == value)
				{
					return;
				}
				_marker2Ref = value;
				PropertySet(this);
			}
		}

		public gameCyberspaceBoundaryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
