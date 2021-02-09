using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DoorStateOperations : DeviceOperations
	{
		[Ordinal(2)]  [RED("doorStateOperations")] public CArray<SDoorStateOperationData> _DoorStateOperations { get; set; }
		[Ordinal(3)]  [RED("wasStateCached")] public CBool WasStateCached { get; set; }
		[Ordinal(4)]  [RED("cachedState")] public CEnum<EDoorStatus> CachedState { get; set; }

		public DoorStateOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
