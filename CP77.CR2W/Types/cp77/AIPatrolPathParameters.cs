using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIPatrolPathParameters : IScriptable
	{
		[Ordinal(0)]  [RED("enterClosest")] public CBool EnterClosest { get; set; }
		[Ordinal(1)]  [RED("isBackAndForth")] public CBool IsBackAndForth { get; set; }
		[Ordinal(2)]  [RED("isInfinite")] public CBool IsInfinite { get; set; }
		[Ordinal(3)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(4)]  [RED("numberOfLoops")] public CUInt32 NumberOfLoops { get; set; }
		[Ordinal(5)]  [RED("path")] public NodeRef Path { get; set; }
		[Ordinal(6)]  [RED("patrolAction")] public TweakDBID PatrolAction { get; set; }
		[Ordinal(7)]  [RED("patrolWithWeapon")] public CBool PatrolWithWeapon { get; set; }
		[Ordinal(8)]  [RED("sortPatrolPoints")] public CBool SortPatrolPoints { get; set; }

		public AIPatrolPathParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
