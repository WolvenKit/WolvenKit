using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameWeaponReplicationHistory : CVariable
	{
		[Ordinal(0)]  [RED("continuousAttack")] public gameReplicatedContinuousAttack ContinuousAttack { get; set; }
		[Ordinal(1)]  [RED("latestShotId")] public CUInt32 LatestShotId { get; set; }
		[Ordinal(2)]  [RED("shots", 8)] public CStatic<gameReplicatedShotData> Shots { get; set; }
		[Ordinal(3)]  [RED("weaponSlot")] public TweakDBID WeaponSlot { get; set; }

		public gameWeaponReplicationHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
