using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questStreamingTestCheckpoint_NodeType : questIWorldDataManagerNodeType
	{
		[Ordinal(0)] [RED("checkpointType")] public CEnum<worldStreamingTestCheckpointType> CheckpointType { get; set; }

		public questStreamingTestCheckpoint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
