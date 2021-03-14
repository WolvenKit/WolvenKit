using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneRef : CVariable
	{
		private NodeRef _nodeRef;
		private CUInt16 _laneNumber;
		private CBool _isReversed;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get
			{
				if (_laneNumber == null)
				{
					_laneNumber = (CUInt16) CR2WTypeManager.Create("Uint16", "laneNumber", cr2w, this);
				}
				return _laneNumber;
			}
			set
			{
				if (_laneNumber == value)
				{
					return;
				}
				_laneNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get
			{
				if (_isReversed == null)
				{
					_isReversed = (CBool) CR2WTypeManager.Create("Bool", "isReversed", cr2w, this);
				}
				return _isReversed;
			}
			set
			{
				if (_isReversed == value)
				{
					return;
				}
				_isReversed = value;
				PropertySet(this);
			}
		}

		public worldTrafficLaneRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
