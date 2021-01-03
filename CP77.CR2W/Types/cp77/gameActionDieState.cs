using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameActionDieState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("movingAgent")] public wCHandle<moveComponent> MovingAgent { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("ragdollComponent")] public wCHandle<entRagdollComponent> RagdollComponent { get; set; }
		[Ordinal(3)]  [RED("slotComponent")] public wCHandle<entSlotComponent> SlotComponent { get; set; }

		public gameActionDieState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
