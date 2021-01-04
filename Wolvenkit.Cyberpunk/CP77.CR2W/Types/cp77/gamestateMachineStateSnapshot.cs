using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateSnapshot : CVariable
	{
		[Ordinal(0)]  [RED("instanceData")] public gamestateMachineStateMachineInstanceData InstanceData { get; set; }
		[Ordinal(1)]  [RED("logicalOwnerIsAWeapon")] public CBool LogicalOwnerIsAWeapon { get; set; }
		[Ordinal(2)]  [RED("running")] public CBool Running { get; set; }
		[Ordinal(3)]  [RED("stateMachineName")] public CName StateMachineName { get; set; }
		[Ordinal(4)]  [RED("stateName")] public CName StateName { get; set; }
		[Ordinal(5)]  [RED("transitionJustHappened")] public CBool TransitionJustHappened { get; set; }

		public gamestateMachineStateSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
