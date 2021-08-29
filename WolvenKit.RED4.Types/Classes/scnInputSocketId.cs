using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInputSocketId : RedBaseClass
	{
		private scnNodeId _nodeId;
		private scnInputSocketStamp _isockStamp;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("isockStamp")] 
		public scnInputSocketStamp IsockStamp
		{
			get => GetProperty(ref _isockStamp);
			set => SetProperty(ref _isockStamp, value);
		}
	}
}
