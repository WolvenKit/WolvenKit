using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetTrafficLaneMovementParams : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("fearStage")] public CEnum<gameFearStage> FearStage { get; set; }
		[Ordinal(1)]  [RED("movementType")] public CString MovementType { get; set; }

		public SetTrafficLaneMovementParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
