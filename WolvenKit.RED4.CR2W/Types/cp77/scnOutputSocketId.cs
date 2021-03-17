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
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("osockStamp")] 
		public scnOutputSocketStamp OsockStamp
		{
			get => GetProperty(ref _osockStamp);
			set => SetProperty(ref _osockStamp, value);
		}

		public scnOutputSocketId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
