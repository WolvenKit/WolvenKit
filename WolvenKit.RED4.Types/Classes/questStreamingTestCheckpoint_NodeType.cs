using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStreamingTestCheckpoint_NodeType : questIWorldDataManagerNodeType
	{
		private CEnum<worldStreamingTestCheckpointType> _checkpointType;

		[Ordinal(0)] 
		[RED("checkpointType")] 
		public CEnum<worldStreamingTestCheckpointType> CheckpointType
		{
			get => GetProperty(ref _checkpointType);
			set => SetProperty(ref _checkpointType, value);
		}
	}
}
