using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventAddOnDemandStateMachine : redEvent
	{
		[Ordinal(0)] [RED("stateMachineName")] public CName StateMachineName { get; set; }
		[Ordinal(1)] [RED("instanceData")] public gamestateMachineStateMachineInstanceData InstanceData { get; set; }
		[Ordinal(2)] [RED("tryHotSwap")] public CBool TryHotSwap { get; set; }
		[Ordinal(3)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public gamestateMachineeventAddOnDemandStateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
