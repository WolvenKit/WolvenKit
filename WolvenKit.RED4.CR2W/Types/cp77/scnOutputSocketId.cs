using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOutputSocketId : CVariable
	{
		private scnNodeId _nodeId;
		private scnOutputSocketStamp _osockStamp;

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
		[RED("osockStamp")] 
		public scnOutputSocketStamp OsockStamp
		{
			get
			{
				if (_osockStamp == null)
				{
					_osockStamp = (scnOutputSocketStamp) CR2WTypeManager.Create("scnOutputSocketStamp", "osockStamp", cr2w, this);
				}
				return _osockStamp;
			}
			set
			{
				if (_osockStamp == value)
				{
					return;
				}
				_osockStamp = value;
				PropertySet(this);
			}
		}

		public scnOutputSocketId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
