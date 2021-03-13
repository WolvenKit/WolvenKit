using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeaponReplicationHistory : CVariable
	{
		[Ordinal(0)] [RED("weaponSlot")] public TweakDBID WeaponSlot { get; set; }
		[Ordinal(1)] [RED("shots", 8)] public CStatic<gameReplicatedShotData> Shots { get; set; }
		[Ordinal(2)] [RED("latestShotId")] public CUInt32 LatestShotId { get; set; }
		[Ordinal(3)] [RED("continuousAttack")] public gameReplicatedContinuousAttack ContinuousAttack { get; set; }

		public gameWeaponReplicationHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
