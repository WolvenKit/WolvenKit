using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questFollowParams : questAICommandParams
	{
		[Ordinal(0)]  [RED("companionDistance")] public CFloat CompanionDistance { get; set; }
		[Ordinal(1)]  [RED("companionRef")] public CHandle<questUniversalRef> CompanionRef { get; set; }
		[Ordinal(2)]  [RED("destinationPointTolerance")] public CFloat DestinationPointTolerance { get; set; }
		[Ordinal(3)]  [RED("matchSpeed")] public CBool MatchSpeed { get; set; }
		[Ordinal(4)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(5)]  [RED("repeatCommandOnInterrupt")] public CBool RepeatCommandOnInterrupt { get; set; }
		[Ordinal(6)]  [RED("stopWhenDestinationReached")] public CBool StopWhenDestinationReached { get; set; }
		[Ordinal(7)]  [RED("useTeleport")] public CBool UseTeleport { get; set; }

		public questFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
