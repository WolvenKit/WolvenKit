using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameNpcPuppetReplicatedState : gamePuppetReplicatedState
	{
		[Ordinal(0)]  [RED("weaponStates")] public gameWeaponsReplicatedState WeaponStates { get; set; }

		public gameNpcPuppetReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
