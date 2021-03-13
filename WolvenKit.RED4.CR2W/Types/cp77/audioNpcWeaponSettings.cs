using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcWeaponSettings : audioWeaponSettings
	{
		[Ordinal(10)] [RED("gunChoir")] public CName GunChoir { get; set; }
		[Ordinal(11)] [RED("tails")] public CName Tails { get; set; }
		[Ordinal(12)] [RED("obstructionEnabled")] public CBool ObstructionEnabled { get; set; }
		[Ordinal(13)] [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(14)] [RED("repositionEnabled")] public CBool RepositionEnabled { get; set; }
		[Ordinal(15)] [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(16)] [RED("disablePathfinding")] public CBool DisablePathfinding { get; set; }
		[Ordinal(17)] [RED("voiceSwitchCooldown")] public CFloat VoiceSwitchCooldown { get; set; }
		[Ordinal(18)] [RED("reloadSound")] public CName ReloadSound { get; set; }
		[Ordinal(19)] [RED("quickMeleeAttackSound")] public CName QuickMeleeAttackSound { get; set; }
		[Ordinal(20)] [RED("quickMeleeHitSound")] public CName QuickMeleeHitSound { get; set; }

		public audioNpcWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
