using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDelayedFunctionsScheduler : ISerializable
	{
		[Ordinal(0)] [RED("initialized")] public CBool Initialized { get; set; }
		[Ordinal(1)] [RED("currentTime")] public EngineTime CurrentTime { get; set; }
		[Ordinal(2)] [RED("nextCallId")] public CUInt32 NextCallId { get; set; }

		public gameDelayedFunctionsScheduler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
