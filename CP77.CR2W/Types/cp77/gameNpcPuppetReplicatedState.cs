using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameNpcPuppetReplicatedState : gamePuppetReplicatedState
	{
		[Ordinal(12)] [RED("weaponStates")] public gameWeaponsReplicatedState WeaponStates { get; set; }

		public gameNpcPuppetReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
