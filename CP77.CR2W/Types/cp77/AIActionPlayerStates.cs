using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIActionPlayerStates : CVariable
	{
		[Ordinal(0)]  [RED("bodyCarryStates")] public CArray<CEnum<gamePSMBodyCarrying>> BodyCarryStates { get; set; }
		[Ordinal(1)]  [RED("locomotionStates")] public CArray<CEnum<gamePSMLocomotionStates>> LocomotionStates { get; set; }
		[Ordinal(2)]  [RED("meleeStates")] public CArray<CEnum<gamePSMMelee>> MeleeStates { get; set; }
		[Ordinal(3)]  [RED("upperBodyStates")] public CArray<CEnum<gamePSMUpperBodyStates>> UpperBodyStates { get; set; }
		[Ordinal(4)]  [RED("zoneStates")] public CArray<CEnum<gamePSMZones>> ZoneStates { get; set; }

		public AIActionPlayerStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
