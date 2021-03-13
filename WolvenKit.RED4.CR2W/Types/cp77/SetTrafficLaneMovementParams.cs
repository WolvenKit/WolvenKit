using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTrafficLaneMovementParams : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("movementType")] public CString MovementType { get; set; }
		[Ordinal(1)] [RED("fearStage")] public CEnum<gameFearStage> FearStage { get; set; }

		public SetTrafficLaneMovementParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
