using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseStateOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] [RED("triggerData")] public CHandle<BaseStateOperationTriggerData> TriggerData { get; set; }
		[Ordinal(1)] [RED("wasStateCached")] public CBool WasStateCached { get; set; }
		[Ordinal(2)] [RED("cachedState")] public CEnum<EDeviceStatus> CachedState { get; set; }

		public BaseStateOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
