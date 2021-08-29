using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnOutputSocketId : RedBaseClass
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
	}
}
