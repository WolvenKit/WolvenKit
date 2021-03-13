using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCannotMoveConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] [RED("statusEffectRemovedId")] public CUInt32 StatusEffectRemovedId { get; set; }

		public PassiveCannotMoveConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
