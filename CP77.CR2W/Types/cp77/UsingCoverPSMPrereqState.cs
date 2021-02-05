using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UsingCoverPSMPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)]  [RED("listenerInt")] public CUInt32 ListenerInt { get; set; }
		[Ordinal(2)]  [RED("prevValue")] public CInt32 PrevValue { get; set; }
		[Ordinal(3)]  [RED("bValue")] public CBool BValue { get; set; }

		public UsingCoverPSMPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
