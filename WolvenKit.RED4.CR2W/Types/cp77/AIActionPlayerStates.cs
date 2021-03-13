using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionPlayerStates : CVariable
	{
		[Ordinal(0)] [RED("locomotionStates")] public CArray<CEnum<gamePSMLocomotionStates>> LocomotionStates { get; set; }
		[Ordinal(1)] [RED("upperBodyStates")] public CArray<CEnum<gamePSMUpperBodyStates>> UpperBodyStates { get; set; }
		[Ordinal(2)] [RED("meleeStates")] public CArray<CEnum<gamePSMMelee>> MeleeStates { get; set; }
		[Ordinal(3)] [RED("zoneStates")] public CArray<CEnum<gamePSMZones>> ZoneStates { get; set; }
		[Ordinal(4)] [RED("bodyCarryStates")] public CArray<CEnum<gamePSMBodyCarrying>> BodyCarryStates { get; set; }

		public AIActionPlayerStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
