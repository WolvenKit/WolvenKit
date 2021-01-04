using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OperationExecutionData : IScriptable
	{
		[Ordinal(0)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(1)]  [RED("delayID")] public gameDelayID DelayID { get; set; }
		[Ordinal(2)]  [RED("isDelayActive")] public CBool IsDelayActive { get; set; }
		[Ordinal(3)]  [RED("operationName")] public CName OperationName { get; set; }
		[Ordinal(4)]  [RED("resetDelay")] public CBool ResetDelay { get; set; }

		public OperationExecutionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
