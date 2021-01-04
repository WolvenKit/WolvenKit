using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DoorStateOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("cachedState")] public CEnum<EDoorStatus> CachedState { get; set; }
		[Ordinal(1)]  [RED("doorStateOperations")] public CArray<SDoorStateOperationData> M_DoorStateOperations { get; set; }
		[Ordinal(2)]  [RED("wasStateCached")] public CBool WasStateCached { get; set; }

		public DoorStateOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
