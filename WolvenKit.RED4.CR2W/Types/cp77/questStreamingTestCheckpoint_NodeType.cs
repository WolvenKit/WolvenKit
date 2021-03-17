using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStreamingTestCheckpoint_NodeType : questIWorldDataManagerNodeType
	{
		private CEnum<worldStreamingTestCheckpointType> _checkpointType;

		[Ordinal(0)] 
		[RED("checkpointType")] 
		public CEnum<worldStreamingTestCheckpointType> CheckpointType
		{
			get => GetProperty(ref _checkpointType);
			set => SetProperty(ref _checkpointType, value);
		}

		public questStreamingTestCheckpoint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
