using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseStateOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("baseStateOperations")] public CArray<SBaseStateOperationData> _BaseStateOperations { get; set; }
		[Ordinal(1)]  [RED("cachedState")] public CEnum<EDeviceStatus> CachedState { get; set; }
		[Ordinal(2)]  [RED("stateActionsOverrides")] public SGenericDeviceActionsData StateActionsOverrides { get; set; }
		[Ordinal(3)]  [RED("wasStateCached")] public CBool WasStateCached { get; set; }

		public BaseStateOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
