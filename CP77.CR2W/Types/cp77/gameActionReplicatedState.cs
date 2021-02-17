using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionReplicatedState : CVariable
	{
		[Ordinal(0)] [RED("replicationId")] public CUInt32 ReplicationId { get; set; }
		[Ordinal(1)] [RED("type")] public CUInt16 Type { get; set; }
		[Ordinal(2)] [RED("startTimeStamp")] public netTime StartTimeStamp { get; set; }
		[Ordinal(3)] [RED("stopTimeStamp")] public netTime StopTimeStamp { get; set; }
		[Ordinal(4)] [RED("updateBucket")] public CUInt8 UpdateBucket { get; set; }

		public gameActionReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
