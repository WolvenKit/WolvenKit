using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInputSocketId : CVariable
	{
		private scnNodeId _nodeId;
		private scnInputSocketStamp _isockStamp;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (scnNodeId) CR2WTypeManager.Create("scnNodeId", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isockStamp")] 
		public scnInputSocketStamp IsockStamp
		{
			get
			{
				if (_isockStamp == null)
				{
					_isockStamp = (scnInputSocketStamp) CR2WTypeManager.Create("scnInputSocketStamp", "isockStamp", cr2w, this);
				}
				return _isockStamp;
			}
			set
			{
				if (_isockStamp == value)
				{
					return;
				}
				_isockStamp = value;
				PropertySet(this);
			}
		}

		public scnInputSocketId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
